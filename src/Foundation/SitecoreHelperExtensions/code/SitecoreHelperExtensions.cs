using Sitecore.Data;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Links.UrlBuilders;
using Sitecore.Mvc.Helpers;
using Sitecore.Resources.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Sitecon.Foundation.SitecoreHelperExtensions
{
  public static class SitecoreHelperExtensions
  {
    public static HtmlString Field(this SitecoreHelper helper, ID fieldID)
    {
      return helper.Field(fieldID.ToString());
    }

    public static HtmlString Field(this SitecoreHelper helper, ID fieldID, object parameters)
    {
      return helper.Field(fieldID.ToString(), parameters);
    }

    public static string GetMediaUrl(this SitecoreHelper sitecoreHelper, ID fieldID, Item item, MediaUrlBuilderOptions options)
    {
      ImageField imageField = item?.Fields[fieldID];
      if (imageField == null || imageField.MediaItem == null)
      {
        return string.Empty;
      }

      var url = options != null ? MediaManager.GetMediaUrl(imageField.MediaItem, options) : MediaManager.GetMediaUrl(imageField.MediaItem);
      return HashingUtils.ProtectAssetUrl(url);
    }

    public static string GetMediaUrl(this SitecoreHelper sitecoreHelper, ID fieldID)
    {
      return GetMediaUrl(sitecoreHelper, fieldID, sitecoreHelper.CurrentItem);
    }

    public static string GetMediaUrl(this SitecoreHelper sitecoreHelper, ID fieldID, Item item)
    {
      return GetMediaUrl(sitecoreHelper, fieldID, item, null);
    }

    public static string GetMediaUrl(this SitecoreHelper sitecoreHelper, ID fieldID, MediaUrlBuilderOptions options)
    {
      return GetMediaUrl(sitecoreHelper, fieldID, sitecoreHelper.CurrentItem, options);
    }
  }
}
