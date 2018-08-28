using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Pagetype
    {
        public Pagetype()
        {
            Page = new HashSet<Page>();
            Pagetemplate = new HashSet<Pagetemplate>();
        }

        public short PageTypeId { get; set; }
        public string Name { get; set; }
        public bool IsUserEditable { get; set; }
        public bool IsContentEditable { get; set; }
        public bool? IsNameEditable { get; set; }
        public bool? IsTitleEditable { get; set; }
        public bool IsDeletable { get; set; }
        public bool IsCreatedOnSiteCreate { get; set; }
        public bool? IsPageLinksEditable { get; set; }
        public bool IsShownOnNewPageList { get; set; }
        public string Filename { get; set; }
        public bool? IsSidebarRequired { get; set; }
        public bool? IsSidebarEditable { get; set; }
        public bool IsSsl { get; set; }
        public string Path { get; set; }
        public bool? IsPreviewAvailable { get; set; }
        public bool? IsShownOnPageLinkList { get; set; }
        public bool? IsShownOnPageList { get; set; }
        public int? CssId { get; set; }

        public Css Css { get; set; }
        public ICollection<Page> Page { get; set; }
        public ICollection<Pagetemplate> Pagetemplate { get; set; }
    }
}
