using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Email
    {
        public Email()
        {
            Cinemaweeklyemailsetting = new HashSet<Cinemaweeklyemailsetting>();
            Emailarchive = new HashSet<Emailarchive>();
            Emailcinemas = new HashSet<Emailcinemas>();
            Emailelement = new HashSet<Emailelement>();
            Emailemailgroups = new HashSet<Emailemailgroups>();
            Emailgeneralsettings = new HashSet<Emailgeneralsettings>();
            Emaillink = new HashSet<Emaillink>();
            Emailmembers = new HashSet<Emailmembers>();
            Emailmembertypes = new HashSet<Emailmembertypes>();
            Includeelementinstance = new HashSet<Includeelementinstance>();
        }

        public Guid EmailId { get; set; }
        public Guid CompanyId { get; set; }
        public string Url { get; set; }
        public string FromAddress { get; set; }
        public string Subject { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime ScheduledDateTime { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? FinishDateTime { get; set; }
        public DateTime ProofDateTime { get; set; }
        public bool IsApprovedByDefault { get; set; }
        public bool IsProofEmailRequired { get; set; }
        public bool IsProofEmailSent { get; set; }
        public bool IsApproved { get; set; }
        public DateTime? ApprovalDateTime { get; set; }
        public Guid? ApprovedByUserId { get; set; }
        public short RepeatInHowManyDays { get; set; }
        public short RepeatForHowManyTimes { get; set; }
        public int NumberOfEmailsToSend { get; set; }
        public int NumberOfEmailsSent { get; set; }
        public short EmailTypeId { get; set; }
        public string Html { get; set; }
        public DateTime ReferenceDate { get; set; }
        public Guid CinemaId { get; set; }
        public bool IsTrackOpenRate { get; set; }
        public short EmailStatusId { get; set; }
        public bool IsDeleted { get; set; }
        public Guid SiteId { get; set; }
        public string ProofRecipientEmailAddress { get; set; }
        public bool IsStarted { get; set; }
        public bool IsFinished { get; set; }
        public int Defer { get; set; }
        public string Error { get; set; }
        public string ReplyToAddress { get; set; }
        public string UnsubscribeUrl { get; set; }
        public string ContactUrl { get; set; }
        public Guid? FilterId { get; set; }
        public int NumberOpened { get; set; }
        public int NumberBounced { get; set; }
        public bool IsIgnoreMissingSessionErrors { get; set; }
        public string SummaryText { get; set; }

        public Cinema Cinema { get; set; }
        public Company Company { get; set; }
        public Emailstatus EmailStatus { get; set; }
        public Emailtype EmailType { get; set; }
        public Filter Filter { get; set; }
        public Site Site { get; set; }
        public ICollection<Cinemaweeklyemailsetting> Cinemaweeklyemailsetting { get; set; }
        public ICollection<Emailarchive> Emailarchive { get; set; }
        public ICollection<Emailcinemas> Emailcinemas { get; set; }
        public ICollection<Emailelement> Emailelement { get; set; }
        public ICollection<Emailemailgroups> Emailemailgroups { get; set; }
        public ICollection<Emailgeneralsettings> Emailgeneralsettings { get; set; }
        public ICollection<Emaillink> Emaillink { get; set; }
        public ICollection<Emailmembers> Emailmembers { get; set; }
        public ICollection<Emailmembertypes> Emailmembertypes { get; set; }
        public ICollection<Includeelementinstance> Includeelementinstance { get; set; }
    }
}
