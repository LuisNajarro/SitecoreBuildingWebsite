using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecon.Feature.Events.Models
{
  public class Event
  {
    public string EventName { get; set; }
    public DateTime EventDate { get; set; }
    public string EventDateString { get; set; }
    public string EventTimeString { get; set; }
    public bool IsFeaturedEvent { get; set; }
    public List<Speaker> EventSpeakers { get; set; }
  }
}
