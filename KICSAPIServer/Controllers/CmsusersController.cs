using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KICSAPIServer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace KICSAPIServer.Controllers
{
    [Route("api/[controller]")]
    public class CmsusersController : ControllerBase
    {
        private readonly KICSDEVContext _context;
        private IConfiguration _config;


        public CmsusersController(KICSDEVContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }



        [HttpGet("Login")]
       // [Authorize]
        public async Task<IActionResult> Login(Guid companyId, Guid cinemaId, Int64 PIN, Guid KTixPosTerminalId)
        {
            if (PIN == 1234567812345678)
            {
                //this is a super user of Kinesis
                //get token
                var tokenString = GenerateJSONWebToken();
                var SUPERuser = new LoginDTO()
                {
                    LoginType = "MASTER",
                    Username = "Kinesis",
                    Status = true,
                    Key = tokenString
                };

                List<LoginDTO> list = new List<LoginDTO>();
                list.Add(SUPERuser);

                if (list != null)
                {

                    return Ok(list);
                }
                else
                {
                    return NotFound("Super user Login Failed");
                }

            }
            else
            {
                var query = from p in _context.Cmsuser
                            where p.CompanyId == companyId
                            && p.IsPosUser == true
                            && p.Pospin == PIN
                            && p.PospinexpiryDate >= DateTime.Now
                            && p.IsLoggedInToPos == false
                            && _context.Cmsusercinemas.Any
                                        (bc => bc.CmsuserId == p.CmsuserId
                                         && bc.CinemaId == cinemaId)
                            select p;
                var result = await query.ToListAsync();
                if (result == null || result.Count() == 0)
                {
                    //this is a cms user of Kinesis
                    var NullUser = new LoginDTO()
                    {
                        LoginType = "CMSUser",
                        Username = "No User",
                        Status = false,
                        CmsUserId = new Guid("00000000-0000-0000-0000-000000000000")
                    };

                    List<LoginDTO> list = new List<LoginDTO>();
                    list.Add(NullUser);

                    if (list != null)
                    {
                        return Ok(list);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                else
                {
                    Cmsuser thisUser =  query.FirstOrDefault();
                    var tokenString = GenerateJSONWebToken();

                    var CMSuser = await query.Select(x => new LoginDTO()
                    {
                        LoginType = "CMSUser",
                        Username = x.Name,
                        Status = true,
                        CmsUserId = x.CmsuserId,
                        Key = tokenString
                    }).ToListAsync();

                    //update table
                    var todo = _context.Cmsuser.Find(thisUser.CmsuserId);
                    todo.IsLoggedInToPos = true;
                    todo.LastKtixPosTerminalId = KTixPosTerminalId;
                    _context.Cmsuser.Update(todo);
                    _context.SaveChanges();

                    if (CMSuser != null)
                    {
                        return Ok(CMSuser);
                    }
                    else
                    {
                        return NotFound();
                    }
                }

            }
        }

        [HttpGet("Logout")]
       // [Authorize]
        public async Task<IActionResult> Logout(Guid CMSuserId)
        {

            var query = from p in _context.Cmsuser
                        where p.CmsuserId == CMSuserId
                        select p;

            var result = await query.ToListAsync();

            if (result == null || result.Count() == 0)
            {
                //this is a super user of Kinesis
                var NullUser = new LoginDTO()
                {
                    LoginType = "SUPER",
                    Username = "Logged out",
                    Status = true
                };

                List<LoginDTO> list = new List<LoginDTO>();
                list.Add(NullUser);

                if (list != null)
                {
                    return Ok(list);
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                Cmsuser thisUser = result.FirstOrDefault();
                var CMSuser = query.Select(x => new LoginDTO()
                {
                    LoginType = "CMSUser",
                    Username = "Logged out",
                    Status = true
                }).ToList();

                //update table
                var todo = _context.Cmsuser.Find(thisUser.CmsuserId);
                todo.IsLoggedInToPos = false;
                _context.Cmsuser.Update(todo);
                _context.SaveChanges();

                if (CMSuser != null)
                {
                    return Ok(CMSuser);
                }
                else
                {
                    return NotFound();
                }
            }
        }

        private string GenerateJSONWebToken()
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);


            var token = new JwtSecurityToken(null,
              null,
              null,
              expires: DateTime.Now.AddDays(1),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }


    }
}
