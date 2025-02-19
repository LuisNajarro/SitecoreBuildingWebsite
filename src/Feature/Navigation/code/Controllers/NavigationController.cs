﻿using Sitecon.Feature.Navigation.Models;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Sitecon.Feature.Navigation.Controllers
{
  public class NavigationController : Controller
  {
    public ActionResult Header()
    {
      if (Sitecore.Context.Item == null)
      {
        return null;
      }

      var dataSourdeId = RenderingContext.CurrentOrNull.Rendering.DataSource;
      if (string.IsNullOrEmpty(dataSourdeId))
      {
        return null;
      }
      var item = Sitecore.Context.Database.GetItem(dataSourdeId);
      if (item == null)
      {
        return null;
      }

      var header = new Header();

      //Image field
      ImageField logo = item.Fields[Templates.Header.Fields.Logo];
      if (logo != null && logo.MediaItem != null)
      {
        var image = new MediaItem(logo.MediaItem);
        header.ImageUrl = Sitecore.StringUtil.EnsurePrefix('/', Sitecore.Resources.Media.MediaManager.GetMediaUrl(image));
        header.ImageAlt = image.Alt;
      }

      //Home Link - Droplink Field
      ReferenceField homeLink = item.Fields[Templates.Header.Fields.HomeLink];
      header.HomeLinkUrl = homeLink != null
        ? Sitecore.Links.LinkManager.GetItemUrl(homeLink.TargetItem)
        : string.Empty;

      //Event Links - DropTree Field with Child Items
      ReferenceField eventsRoot = item.Fields[Templates.Header.Fields.EventsRoot];
      header.Events = new List<NavigationItem>();
      foreach (Item i in eventsRoot.TargetItem.Children)
      {
        var navigationItem = new NavigationItem();
        navigationItem.Item = i;
        navigationItem.ItemUrl = i != null
          ? Sitecore.Links.LinkManager.GetItemUrl(i)
          : string.Empty;

        header.Events.Add(navigationItem);
      }

      //Schedule Link - General Link with Anchor
      LinkField scheduleLink = item.Fields[Templates.Header.Fields.ScheduleLink];
      header.ScheduleLinkUrl = scheduleLink != null
        ? string.Format("{0}#{1}", Sitecore.Links.LinkManager.GetItemUrl(scheduleLink.TargetItem), scheduleLink.Anchor)
        : string.Empty;
      
      //Setting IsExperienceEditor
      header.IsExperienceEditor = Sitecore.Context.PageMode.IsExperienceEditor;

      return View(header);
    }

    public ActionResult Footer()
    {
      if (Sitecore.Context.Item == null)
      {
        return null;
      }

      var dataSourdeId = RenderingContext.CurrentOrNull.Rendering.DataSource;
      if (string.IsNullOrEmpty(dataSourdeId))
      {
        return null;
      }
      var item = Sitecore.Context.Database.GetItem(dataSourdeId);
      if (item == null)
      {
        return null;
      }

      var footer = new Footer();

      //Left Text
      footer.FooterTextLeft = item.Fields[Templates.Footer.Fields.FooterTextLeft].Value;

      //Left Link - General Link with Search Field
      LinkField leftLink = item.Fields[Templates.Footer.Fields.FooterLinkLeft];
      footer.FooterLinkUrlLeft = leftLink != null && leftLink.TargetItem != null
        ? string.Format("{0}#{1}", Sitecore.Links.LinkManager.GetItemUrl(leftLink.TargetItem), leftLink.Anchor)
        : string.Empty;
      footer.FooterLinkTargetLeft = leftLink.Target;
      footer.FooterLinkTextLeft = item.Fields[Templates.Footer.Fields.FooterLinkTextLeft].Value;

      //Right Text
      footer.FooterTextRight = item.Fields[Templates.Footer.Fields.FooterTextRight].Value;

      //Right Link - General Link Field
      LinkField rightLink = item.Fields[Templates.Footer.Fields.FooterLinkRight];
      footer.FooterLinkUrlRight = rightLink != null && rightLink.TargetItem != null
        ? Sitecore.Links.LinkManager.GetItemUrl(rightLink.TargetItem)
        : rightLink.Url;
      footer.FooterLinkTargetRight = rightLink.Target;
      footer.FooterLinkTextRight = item.Fields[Templates.Footer.Fields.FooterLinkTextRight].Value;

      return View(footer);
    }
  }
}
