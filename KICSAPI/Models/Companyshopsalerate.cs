using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Companyshopsalerate
    {
        public short CompanyShopSaleRateId { get; set; }
        public int NumberOfShopSalesStart { get; set; }
        public int NumberOfShopSalesFinish { get; set; }
        public decimal RatePerShopSale { get; set; }
        public Guid CompanyId { get; set; }

        public Company Company { get; set; }
    }
}
