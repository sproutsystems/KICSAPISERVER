using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Popupcinema
    {
        public int PopUpCinemaId { get; set; }
        public int PopUpId { get; set; }
        public Guid CinemaId { get; set; }
        public DateTime CreateDateTime { get; set; }

        public Cinema Cinema { get; set; }
        public Popup PopUp { get; set; }
    }
}
