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
    public class KioskController : ControllerBase
    {
        private readonly KICSDEVContext _context;

        public KioskController(KICSDEVContext context)
        {
            _context = context;
        }

        [HttpGet("GetKioskCategories")]
       // [Authorize]
        public async Task<IActionResult> GetKioskCategories(Guid ktixSettingId)
        {
            var result = new List<KioskCategoriesDTO>();


            var query = from p in _context.Ktixkioskcategory
                        where p.KtixSettingId == ktixSettingId
                        orderby p.DisplayOrder
                        select p;

            var list = await query.ToListAsync();


            foreach (var item in list)
            {
                string bgcolor = item.bgCode;
                if (item.IsAvaliable == false)
                    bgcolor = "#d0d0d0";


                result.Add(new KioskCategoriesDTO()
                {
                    KTixKioskCategoryId = item.KtixKioskCategoryId,
                    Name = item.Name,
                    DisplayOrder = item.DisplayOrder,
                    IconURL = item.IconURL,
                    BgCode = bgcolor,
                    IsAvaliable = item.IsAvaliable,
                    IconURLDisabled = item.IconURLDisabled
                });
            }

            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
            
        }

        [HttpGet("GetProductsByCategoryId")]
       // [Authorize]
        public async Task<IActionResult> GetProductsByCategoryId(Guid KTixKioskCategoryId)
        {
            var query = from p in _context.Ktixkiosksaleitem
                        where p.KtixKioskCategoryId == KTixKioskCategoryId
                        orderby p.DefaultPrice
                        select p;

            var categories = await query.Select(x => new KioskCategoryProductsDTO()
            {
                KTixKioskSaleItemId = x.KtixKioskSaleItemId,
                Name = x.Name,
                DefaultPrice = x.DefaultPrice,
                MaxQuantity = x.MaxQuantity,
                IsAvaliable = x.IsAvaliable,
                IsSoldOut = x.IsSoldOut
            }).ToListAsync();

            if (categories != null)
            {
                return Ok(categories);
            }
            else
            {
                return NotFound();
            }   
        }

        //[HttpGet("GetDependantCategories")]
        //public async Task<IActionResult> GetDependantCategories(Guid ktixSettingId)
        //{
        //    var query = from p in _context.Ktixitemgroup
        //                where p.KtixSettingId == ktixSettingId
        //                && p.IsAvaliable == true
        //                && p.IsTicket == false
        //                orderby p.DisplayOrder
        //                select p;

        //    var categories = await query.Select(x => new DependantCategoriesDTO()
        //    {
        //        KTixItemGroupId = x.KtixItemGroupId,
        //        Name = x.Name,
        //        DisplayOrder = x.DisplayOrder,
        //        IconURL = x.IconURL,
        //        bgCode = x.bgCode,
        //        IsAvaliable = x.IsAvaliable
        //    }).ToListAsync();

        //    return Ok(categories);
        //}

        //[HttpGet("GetProductsByDependantCategoryId")]
        //public async Task<IActionResult> GetProductsByDependantCategoryId(Guid KTixItemGroupId)
        //{
        //    var query = from p in _context.Ktixsaleitem
        //                where p.KtixItemGroupId == KTixItemGroupId
        //                && p.IsTicket == false
        //                orderby p.DefaultPrice
        //                select p;

        //    var categories = await query.Select(x => new DependantCategoryProductsDTO()
        //    {
        //        KTixSaleItemId = x.KtixSaleItemId,
        //        Name = x.Name,
        //        DefaultPrice = x.DefaultPrice
        //    }).ToListAsync();

        //    return Ok(categories);
        //}
    }
}
