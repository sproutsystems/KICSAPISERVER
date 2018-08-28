using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Systembug
    {
        public Systembug()
        {
            Systembugcomment = new HashSet<Systembugcomment>();
            Systemupdatesystembugs = new HashSet<Systemupdatesystembugs>();
        }

        public int SystemBugId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid? UserId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public DateTime? SolvedDateTime { get; set; }
        public bool IsVerified { get; set; }
        public int SystemBugTypeId { get; set; }
        public short ImportanceOutOfFive { get; set; }
        public string WorkAround { get; set; }
        public string ProposedSolution { get; set; }

        public Systembugtype SystemBugType { get; set; }
        public AspnetUsers User { get; set; }
        public ICollection<Systembugcomment> Systembugcomment { get; set; }
        public ICollection<Systemupdatesystembugs> Systemupdatesystembugs { get; set; }
    }
}
