using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KICSAPIServer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KICSAPIServer.Controllers
{
    [Route("api/[controller]")]
    public class KtixposusetypesController : ControllerBase
    {
        private readonly KICSDEVContext _context;

        public KtixposusetypesController(KICSDEVContext context)
        {
            _context = context;
        }

        [HttpGet("GetPOSUseTypes")]
       // [Authorize]
        public async Task<IActionResult> GetPOSUseTypes()
        {
            var query = from p in _context.Ktixposusetype
                        select p;
            var POSusetypes = await query.ToListAsync();

            if (POSusetypes != null || POSusetypes.Count() > 0)
            {
                return Ok(POSusetypes);
            }
            else
            {
                return NotFound();
            }

        }

        [HttpGet("GetPOSUseTypeById")]
       // [Authorize]
        public async Task<IActionResult> GetPOSUseTypeById(int id)
        {

            var query = from p in _context.Ktixposusetype
                        where p.KtixPosUseTypeId == id
                        select p;

            var ktixpostype = await query.Select(x => new KtixPosTypeNameDTO()
            {
                KTixPosTypeName = x.Name,

            }).ToListAsync();

            if (ktixpostype != null || ktixpostype.Count() > 0)
            {
                return Ok(ktixpostype);
            }
            else
            {
                return NotFound();
            }
        }

    }
}
