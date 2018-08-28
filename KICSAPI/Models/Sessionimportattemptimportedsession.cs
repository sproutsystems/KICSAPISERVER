using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Sessionimportattemptimportedsession
    {
        public long SessionImportAttemptImportedSessionId { get; set; }
        public string SessionPointOfSaleId { get; set; }
        public string MovieTitle { get; set; }
        public string MovieId { get; set; }
        public DateTime SessionDateTime { get; set; }
        public string ScreenNumber { get; set; }
        public bool IsAllocatedSeating { get; set; }
        public int SessionImportAttemptId { get; set; }
        public int? NumberOfSeatsRemaining { get; set; }
        public bool IsOnlineTicketingEnable { get; set; }
        public bool IsNft { get; set; }
        public bool IsAd { get; set; }
        public bool IsCc { get; set; }
        public bool IsLq { get; set; }

        public Sessionimportattempt SessionImportAttempt { get; set; }
    }
}
