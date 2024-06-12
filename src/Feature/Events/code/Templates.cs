using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace Sitecon.Feature.Events
{
  public static class Templates
  {
    public static class Speaker
    {
      public static class Fields
      {
        public static readonly ID SpeakerName = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID SpeakerTitle = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID SpeakerImage = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID SpeakerDescription = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID SpeakerTwitterUrl = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID SpeakerLinkedInUrl = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID SpeakerWebsiteUrl = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
      }
    }

    public static class FeaturedSpeaker
    {
      public static class Fields
      {
        public static readonly ID FeaturedSpeakersTitle = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID FeaturedSpeakersText = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID FeaturedSpeaker = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID FeaturedSpeakersList = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
      }
    }

    public static class Event
    {
      public static class Fields
      {
        public static readonly ID EventName = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID EventDate = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID IsFeaturedEvent = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID EventSpeakers = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
      }
    }

    public static class EventSchedule
    {
      public static class Fields
      {
        public static readonly ID EventScheduleBackground = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID EventScheduleTitle = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID EventScheduleDay1Title = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID EventScheduleDay1Date = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID EventScheduleDay1Location = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID EventScheduleDay1Events = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID EventScheduleDay2Title = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID EventScheduleDay2Date = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID EventScheduleDay2Location = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
        public static readonly ID EventScheduleDay2Events = new ID("{AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA}");
      }
    }
  }
}