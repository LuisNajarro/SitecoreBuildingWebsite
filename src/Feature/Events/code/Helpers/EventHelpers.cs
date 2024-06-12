using Sitecon.Feature.Events.Models;
using Sitecore.Data.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecon.Feature.Events.Helpers
{
  public class EventHelpers
  {
    public List<Event> PopulateEventList(MultilistField eventListField)
    {
      var eventItems = eventListField.GetItems();
      var eventList = new List<Event>();
      if (eventItems != null && eventItems.Count() > 0)
      {
        foreach (var ev in eventItems)
        {
          var e = new Event();
          var eventItem = Sitecore.Context.Database.GetItem(ev.ID);
          e.EventName = eventItem.Fields[Templates.Event.Fields.EventName.ToString()].Value;
          CheckboxField isFeaturedEventField = eventItem.Fields[Templates.Event.Fields.IsFeaturedEvent];
          e.IsFeaturedEvent = isFeaturedEventField.Checked;
          DateField eventDateField = eventItem.Fields[Templates.Event.Fields.EventDate];
          e.EventDate = eventDateField.DateTime.ToLocalTime();
          e.EventDateString = eventDateField.DateTime.ToLocalTime().ToString("f");
          e.EventTimeString = eventDateField.DateTime.ToLocalTime().ToString("t");

          //TreelistEx
          MultilistField eventSpeakersField = eventItem.Fields[Templates.Event.Fields.EventSpeakers];
          var eventSpeakerItems = eventSpeakersField.GetItems();
          var eventSpeakerList = new List<Speaker>();
          if (eventSpeakerItems != null && eventSpeakerItems.Count() > 0)
          {
            foreach (var sp in eventSpeakerItems)
            {
              var speaker = new Speaker();
              var speakerItem = Sitecore.Context.Database.GetItem(sp.ID);
              speaker.SpeakerName = speakerItem.Fields[Templates.Speaker.Fields.SpeakerName.ToString()].Value;
              ImageField speakerImage = speakerItem.Fields[Templates.Speaker.Fields.SpeakerImage];
              speaker.SpeakerImageUrl = Sitecore.Resources.Media.MediaManager.GetMediaUrl(speakerImage.MediaItem);
              speaker.SpeakerImageAlt = speakerImage.Alt;

              eventSpeakerList.Add(speaker);
            }

            e.EventSpeakers = eventSpeakerList;
          }

          eventList.Add(e);
        }
      }

      return eventList;
    }
  }
}
