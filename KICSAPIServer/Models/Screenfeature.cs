using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Screenfeature
    {
        public Screenfeature()
        {
            Screenscreenfeatures = new HashSet<Screenscreenfeatures>();
        }

        public Guid ScreenFeatureId { get; set; }
        public Guid CinemaId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Cinema Cinema { get; set; }
        public ICollection<Screenscreenfeatures> Screenscreenfeatures { get; set; }
    }
}
