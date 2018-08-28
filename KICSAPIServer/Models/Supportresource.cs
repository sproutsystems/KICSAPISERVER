using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Supportresource
    {
        public Supportresource()
        {
            Supportresourcecomment = new HashSet<Supportresourcecomment>();
            Supportresourcestep = new HashSet<Supportresourcestep>();
        }

        public int SupportResourceId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public string Title { get; set; }
        public string Tags { get; set; }
        public string Summary { get; set; }
        public string UserInformation { get; set; }
        public string AdminInformation { get; set; }
        public string DeveloperInformation { get; set; }

        public ICollection<Supportresourcecomment> Supportresourcecomment { get; set; }
        public ICollection<Supportresourcestep> Supportresourcestep { get; set; }
    }
}
