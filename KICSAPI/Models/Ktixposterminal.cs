using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Ktixposterminal
    {
        public Ktixposterminal()
        {
            Ktixmastertransaction = new HashSet<Ktixmastertransaction>();
        }

        public Guid KtixPosTerminalId { get; set; }
        public int KtixPosUseTypeId { get; set; }
        public string KtixDescription { get; set; }
        public Guid CompanyId { get; set; }
        public Guid CinemaId { get; set; }
        public string DeviceName { get; set; }
        public string DeviceId { get; set; }
        public string DeviceModel { get; set; }
        public string Ipaddress { get; set; }
        public string ApiendPoint { get; set; }

        public Cinema Cinema { get; set; }
        public Company Company { get; set; }
        public Ktixposusetype KtixPosUseType { get; set; }
        public ICollection<Ktixmastertransaction> Ktixmastertransaction { get; set; }
    }
}
