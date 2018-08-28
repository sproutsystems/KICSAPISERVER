using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Includeelementinstance
    {
        public Includeelementinstance()
        {
            Includeelementinstancecinemas = new HashSet<Includeelementinstancecinemas>();
            Includeelementinstancemembertypes = new HashSet<Includeelementinstancemembertypes>();
            Includeelementinstanceversion = new HashSet<Includeelementinstanceversion>();
        }

        public int IncludeElementInstanceId { get; set; }
        public Guid IncludeElementId { get; set; }
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
        public bool? IsDisplayOnMobile { get; set; }
        public bool? IsDisplayOnTablet { get; set; }
        public bool? IsDisplayOnDesktop { get; set; }
        public int DisplayOrder { get; set; }
        public int DisplayOrderDesktop { get; set; }
        public int DisplayOrderTablet { get; set; }
        public int DisplayOrderMobile { get; set; }
        public Guid? EmailId { get; set; }
        public Guid? MovieTypeId { get; set; }
        public Guid? PromotionId { get; set; }
        public Guid? SidebarId { get; set; }
        public Guid? PageId { get; set; }
        public Guid? SiteHomePageTabId { get; set; }
        public Guid? PageTemplateId { get; set; }
        public int? CssId { get; set; }
        public bool IsUserEditable { get; set; }
        public bool IsConfigured { get; set; }
        public string RelatedId { get; set; }
        public Guid? FooterId { get; set; }
        public Guid? DrawerId { get; set; }
        public bool IsToggle1 { get; set; }
        public bool IsToggle2 { get; set; }
        public bool IsToggle3 { get; set; }
        public int? NumericOptionValue1 { get; set; }
        public int? NumericOptionValue2 { get; set; }
        public int? NumericOptionValue3 { get; set; }
        public string Anchor { get; set; }
        public bool IsDeleted { get; set; }

        public Css Css { get; set; }
        public Drawer Drawer { get; set; }
        public Email Email { get; set; }
        public Footer Footer { get; set; }
        public Includeelement IncludeElement { get; set; }
        public Movietype MovieType { get; set; }
        public Page Page { get; set; }
        public Pagetemplate PageTemplate { get; set; }
        public Promotion Promotion { get; set; }
        public Sidebar Sidebar { get; set; }
        public Sitehomepagetab SiteHomePageTab { get; set; }
        public ICollection<Includeelementinstancecinemas> Includeelementinstancecinemas { get; set; }
        public ICollection<Includeelementinstancemembertypes> Includeelementinstancemembertypes { get; set; }
        public ICollection<Includeelementinstanceversion> Includeelementinstanceversion { get; set; }
    }
}
