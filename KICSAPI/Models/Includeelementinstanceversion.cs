using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Includeelementinstanceversion
    {
        public int IncludeElementInstanceVersionId { get; set; }
        public int IncludeElementInstanceId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Text { get; set; }
        public string SecondText { get; set; }
        public string ThirdText { get; set; }
        public int Limit { get; set; }
        public string LinkText { get; set; }
        public string LinkUrl { get; set; }
        public int Margin { get; set; }
        public bool? IsPublic { get; set; }
        public bool IsResetAfterSending { get; set; }
        public bool? IsShowOnIndex { get; set; }
        public string PassThroughData { get; set; }
        public string InformationText { get; set; }
        public int VersionId { get; set; }

        public Includeelementinstance IncludeElementInstance { get; set; }
    }
}
