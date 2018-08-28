using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Form
    {
        public Form()
        {
            Formcinema = new HashSet<Formcinema>();
            Formfield = new HashSet<Formfield>();
        }

        public Guid FormId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid CompanyId { get; set; }
        public string SubmitButtonText { get; set; }
        public string SuccessText { get; set; }
        public string SendingEmailAddress { get; set; }
        public string EmailMessageText { get; set; }
        public string EmailMessageSubject { get; set; }

        public Company Company { get; set; }
        public ICollection<Formcinema> Formcinema { get; set; }
        public ICollection<Formfield> Formfield { get; set; }
    }
}
