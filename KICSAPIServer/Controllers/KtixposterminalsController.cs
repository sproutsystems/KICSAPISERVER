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
    public class KtixposterminalsController : ControllerBase
    {
        private readonly KICSDEVContext _context;

        public KtixposterminalsController(KICSDEVContext context)
        {
            _context = context;
        }

        [HttpGet("GetPosTerminalDetails")]
       // [Authorize]
        public async Task<IActionResult> GetPosTerminalDetails(Guid KTixPosTerminalId)
        {
            var query = from p in _context.Ktixposterminal
                        where p.KtixPosTerminalId == KTixPosTerminalId
                        select p;

            var pos = await query.Select(x => new KtixPosTerminalDTO()
            {
                KTixPosTerminalId = x.KtixPosTerminalId,
                KTixPosUseTypeId = x.KtixPosUseTypeId,
                KTixDescription = x.KtixDescription,
                CompanyId = x.CompanyId,
                CinemaId = x.CinemaId,
                DeviceName = x.DeviceName,
                DeviceId = x.DeviceId,
                DeviceModel = x.DeviceModel,
                IPAddress = x.Ipaddress,
                APIEndPoint = x.ApiendPoint
            }).ToListAsync();

            if (pos != null)
            {
                return Ok(pos);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost("UpdateOrCreatePosTerminal")]
     //   [Authorize]
        public async Task<IActionResult> UpdateOrCreatePosTerminal(Guid KTixPosTerminalId, int KtixPosUseTypeId, String KtixDescription, Guid CompanyId, Guid CinemaId, String DeviceName, String DeviceId, String DeviceModel, String Ipaddress, String ApiendPoint)
        {

            var query = from p in _context.Ktixposterminal
                        where p.KtixPosTerminalId == KTixPosTerminalId
                        select p;
            if (query == null || query.Count() == 0)
            {
                //create a new record
                Ktixposterminal newTerminal = new Ktixposterminal()
                {
                    KtixPosTerminalId = Guid.NewGuid(),
                    KtixPosUseTypeId = KtixPosUseTypeId,
                    KtixDescription = KtixDescription,
                    CompanyId = CompanyId,
                    CinemaId = CinemaId,
                    DeviceName = DeviceName,
                    DeviceId = DeviceId,
                    DeviceModel = DeviceModel,
                    Ipaddress = Ipaddress,
                    ApiendPoint = ApiendPoint
                };

                _context.Add(newTerminal);
                _context.SaveChanges();


                //returm DTO object back
                List<KtixPosTerminalDTO> Poslist = new List<KtixPosTerminalDTO>();

                var pos = new KtixPosTerminalDTO()
                {
                    KTixPosTerminalId = newTerminal.KtixPosTerminalId,
                    KTixPosUseTypeId = newTerminal.KtixPosUseTypeId,
                    KTixDescription = newTerminal.KtixDescription,
                    CompanyId = newTerminal.CompanyId,
                    CinemaId = newTerminal.CinemaId,
                    DeviceName = newTerminal.DeviceName,
                    DeviceId = newTerminal.DeviceId,
                    DeviceModel = newTerminal.DeviceModel,
                    IPAddress = newTerminal.Ipaddress,
                    APIEndPoint = newTerminal.ApiendPoint
                };

                Poslist.Add(pos);
                return Ok(Poslist);


            }
            //update
            else
            {

                //update object
                Ktixposterminal thisTerminal = query.FirstOrDefault();
                var todo = _context.Ktixposterminal.Find(thisTerminal.KtixPosTerminalId);

                todo.KtixPosUseTypeId = KtixPosUseTypeId;
                todo.KtixDescription = KtixDescription;
                todo.CompanyId = CompanyId;
                todo.CinemaId = CinemaId;
                todo.DeviceName = DeviceName;
                todo.DeviceId = DeviceId;
                todo.DeviceModel = DeviceModel;
                todo.Ipaddress = Ipaddress;
                todo.ApiendPoint = ApiendPoint;
                _context.Ktixposterminal.Update(todo);
                _context.SaveChanges();

                //returm DTO object back
                var pos = await query.Select(x => new KtixPosTerminalDTO()
                {
                    KTixPosTerminalId = x.KtixPosTerminalId,
                    KTixPosUseTypeId = x.KtixPosUseTypeId,
                    KTixDescription = x.KtixDescription,
                    CompanyId = x.CompanyId,
                    CinemaId = x.CinemaId,
                    DeviceName = x.DeviceName,
                    DeviceId = x.DeviceId,
                    DeviceModel = x.DeviceModel,
                    IPAddress = x.Ipaddress,
                    APIEndPoint = x.ApiendPoint
                }).ToListAsync();

                return Ok(pos);
            }
        }


     
    }
}
