using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Maininteractiveelement
    {
        public short MainInteractiveElementId { get; set; }
        public string Text { get; set; }
        public string LinkUrl { get; set; }
        public short DisplayOrder { get; set; }
        public short MainInteractiveElementTypeId { get; set; }
        public string PassThroughData { get; set; }
        public Guid CinemaGroupId { get; set; }
        public string InformationText { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public string LongText { get; set; }
        public string BuyUrl { get; set; }
        public bool? IsShowDescription { get; set; }

        public Cinemagroup CinemaGroup { get; set; }
        public Maininteractiveelementtype MainInteractiveElementType { get; set; }
    }
}
