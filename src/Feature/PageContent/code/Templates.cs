using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace Sitecon.Feature.PageContent
{
  public static class Templates
  {
    public static class BodyCopy
    {
      public static class Fields
      {
        public static readonly ID BodyCopy = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
      }
    }

    public static class TwoImage
    {
      public static class Fields
      {
        public static readonly ID Image1 = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID Image2 = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
      }
    }

    public static class ListWithIcons
    {
      public static class Fields
      {
        public static readonly ID ListIcon = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID ListText = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
      }
    }

    public static class Hero
    {
      public static class Fields
      {
        public static readonly ID HeroBackgroundImage = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID HeroTitle = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID HeroSubtitle = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
      }
    }

    public static class YouTubeVideo
    {
      public static class Fields
      {
        public static readonly ID YouTubeVideoId = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
      }
    }
  }
}