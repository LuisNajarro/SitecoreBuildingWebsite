using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace Sitecon.Feature.Homepage
{
  public static class Templates
  {
    public static class HomepageTwoColumnCTA
    {
      public static class Fields
      {
        public static readonly ID Column1Title = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID Column1Text = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID Column1Link = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID Column1Image = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID Column2Title = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID Column2Text = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID Column2Link = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID Column2Image = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
      }
    }

    public static class HomepageCTA
    {
      public static class Fields
      {
        public static readonly ID CTABackgroundImage = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID CTATitle = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID CTAText = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID CTALink = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
      }
    }

    public static class HomepageHero
    {
      public static class Fields
      {
        public static readonly ID HomepageHeroBackgroundImage = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID HomepageHeroTagline = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID HomepageHeroTitle = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID HomepageHeroSubtitle = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID HomepageHeroCTALink = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID HomepageHeroCTALinkText = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
      }
    }
  }
}