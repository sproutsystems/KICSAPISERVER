using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Emailtemplatetypeelements
    {
        public int EmailTemplateTypeElementId { get; set; }
        public int EmailTemplateTypeId { get; set; }
        public Guid IncludeElementId { get; set; }
        public int DisplayOrder { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string PassThroughData { get; set; }
        public string InformationText { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public short Limit { get; set; }
        public bool IsResetAfterSending { get; set; }
        public string SubTitle { get; set; }
        public string LinkText { get; set; }
        public string LinkUrl { get; set; }
        public bool? IsShowOnIndex { get; set; }

        public Emailtemplatetype EmailTemplateType { get; set; }
    }
}
