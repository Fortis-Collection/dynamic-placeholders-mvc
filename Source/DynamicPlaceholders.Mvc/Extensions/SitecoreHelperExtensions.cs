using Sitecore.Mvc.Helpers;
using Sitecore.Mvc.Presentation;
using System.Web;

namespace DynamicPlaceholders.Mvc.Extensions
{
	public static class SitecoreHelperExtensions
	{
		public static HtmlString DynamicPlaceholder(this SitecoreHelper helper, string placeholderName)
		{
			var placeholder = PlaceholdersContext.Add(placeholderName, RenderingContext.Current.Rendering.UniqueId);

			return helper.Placeholder(placeholder);
		}
	}
}
