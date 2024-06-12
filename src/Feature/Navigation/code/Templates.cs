using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace Sitecon.Feature.Navigation
{
  public static class Templates
  {
    public static class Header
    {
      public static class Fields
      {
        public static readonly ID Logo = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID HomeLink = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID EventsRoot = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID ScheduleLink = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
      }
    }

    public static class Footer
    {
      public static class Fields
      {
        public static readonly ID FooterTextLeft = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID FooterLinkLeft = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID FooterLinkTextLeft = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID FooterTextRight = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID FooterLinkRight = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID FooterLinkTextRight = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
      }
    }
  }
}