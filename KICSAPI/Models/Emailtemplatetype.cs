using System;
using System.Collections.Generic;

namespace KICSAPI.Models
{
    public partial class Emailtemplatetype
    {
        public Emailtemplatetype()
        {
            Emailgeneralsettings = new HashSet<Emailgeneralsettings>();
            Emailtemplatetypeelements = new HashSet<Emailtemplatetypeelements>();
        }

        public int EmailTemplateTypeId { get; set; }
        public string Name { get; set; }
        public Guid CinemaId { get; set; }
        public DateTime Createdatetime { get; set; }
        public DateTime LastModifyDateTime { get; set; }
        public string EmailBgColor { get; set; }
        public string ContentBgColor { get; set; }
        public int? SectionInternalPaddingTop { get; set; }
        public int? SectionInternalPaddingRight { get; set; }
        public int? SectionInternalPaddingBottom { get; set; }
        public int? SectionInternalPaddingLeft { get; set; }
        public string GeneralFont { get; set; }
        public int? GeneralFontSize { get; set; }
        public string GeneralFontColor { get; set; }
        public bool? GeneralFontBold { get; set; }
        public bool? GeneralFontItalic { get; set; }
        public string Header1Font { get; set; }
        public int? Header1FontSize { get; set; }
        public string Header1FontColor { get; set; }
        public bool Header1FontBold { get; set; }
        public bool Header1FontItalic { get; set; }
        public string Header2Font { get; set; }
        public int? Header2FontSize { get; set; }
        public string Header2FontColor { get; set; }
        public bool Header2FontBold { get; set; }
        public bool Header2FontItalic { get; set; }
        public string Header3Font { get; set; }
        public int? Header3FontSize { get; set; }
        public string Header3FontColor { get; set; }
        public bool Header3FontBold { get; set; }
        public bool Header3FontItalic { get; set; }
        public string HyperlinkColor { get; set; }
        public bool HyperlinkUnderline { get; set; }
        public int? LineHeight { get; set; }
        public string ButtonFont { get; set; }
        public int? ButtonFontSize { get; set; }
        public string ButtonFontColor { get; set; }
        public bool ButtonFontBold { get; set; }
        public bool ButtonFontItalic { get; set; }
        public int? ButtonPaddingTop { get; set; }
        public int? ButtonPaddingRight { get; set; }
        public int? ButtonPaddingBottom { get; set; }
        public int? ButtonPaddingLeft { get; set; }
        public string ButtonBackgroundColor { get; set; }

        public Cinema Cinema { get; set; }
        public ICollection<Emailgeneralsettings> Emailgeneralsettings { get; set; }
        public ICollection<Emailtemplatetypeelements> Emailtemplatetypeelements { get; set; }
    }
}
