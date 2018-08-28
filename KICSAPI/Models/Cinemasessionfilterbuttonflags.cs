using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Cinemasessionfilterbuttonflags
    {
        public int CinemaSessionFilterButtonFlagId { get; set; }
        public int CinemaSessionFilterButtonId { get; set; }
        public short FlagId { get; set; }

        public Cinemasessionfilterbutton CinemaSessionFilterButton { get; set; }
        public Flag Flag { get; set; }
    }
}
