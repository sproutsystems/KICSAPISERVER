using System;
using System.Collections.Generic;

namespace KICSAPIServer.Models
{
    public partial class Includeelement
    {
        public Includeelement()
        {
            Emailelement = new HashSet<Emailelement>();
            Includeelementinstance = new HashSet<Includeelementinstance>();
            Includeelementsites = new HashSet<Includeelementsites>();
            Movietypeelement = new HashSet<Movietypeelement>();
            Pageregion = new HashSet<Pageregion>();
            Pagetemplateregion = new HashSet<Pagetemplateregion>();
            Pagetemplateregioncontent = new HashSet<Pagetemplateregioncontent>();
            Promotionelement = new HashSet<Promotionelement>();
            Sidebarelement = new HashSet<Sidebarelement>();
            Sitehomepagetab = new HashSet<Sitehomepagetab>();
        }

        public Guid IncludeElementId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string UserControlFileName { get; set; }
        public string DataRequirements { get; set; }
        public Guid? AdvertisementLocationTypeId { get; set; }
        public short IncludeElementTypeId { get; set; }
        public int? DefaultLimit { get; set; }
        public string LimitName { get; set; }
        public string DefaultTitle { get; set; }
        public bool? IsGeneric { get; set; }
        public bool? IsCacheable { get; set; }
        public bool IsResponsive { get; set; }
        public bool? IsCanDisplayOnMobile { get; set; }
        public bool? IsCanDisplayOnTablet { get; set; }
        public bool? IsCanDisplayOnDesktop { get; set; }
        public int? CssId { get; set; }
        public short? ContentTypeId { get; set; }
        public string BooleanToggle1Name { get; set; }
        public string BooleanToggle2Name { get; set; }
        public string BooleanToggle3Name { get; set; }
        public string NumericOption1Name { get; set; }
        public string NumericOption2Name { get; set; }
        public string NumericOption3Name { get; set; }
        public bool? IsFixedSize { get; set; }

        public Contenttype ContentType { get; set; }
        public Css Css { get; set; }
        public Includeelementtype IncludeElementType { get; set; }
        public ICollection<Emailelement> Emailelement { get; set; }
        public ICollection<Includeelementinstance> Includeelementinstance { get; set; }
        public ICollection<Includeelementsites> Includeelementsites { get; set; }
        public ICollection<Movietypeelement> Movietypeelement { get; set; }
        public ICollection<Pageregion> Pageregion { get; set; }
        public ICollection<Pagetemplateregion> Pagetemplateregion { get; set; }
        public ICollection<Pagetemplateregioncontent> Pagetemplateregioncontent { get; set; }
        public ICollection<Promotionelement> Promotionelement { get; set; }
        public ICollection<Sidebarelement> Sidebarelement { get; set; }
        public ICollection<Sitehomepagetab> Sitehomepagetab { get; set; }
    }
}
