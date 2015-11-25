using System.Linq;
using Sitecore.Mvc.Helpers;
using Sitecore.Mvc.Presentation;
using System.Collections.Generic;
using System.Web;

namespace DynamicPlaceholders.Mvc.Extensions
{
	public static class SitecoreHelperExtensions
	{
		public static List<string> DynamicPlaceholders = new List<string>();

		public static HtmlString DynamicPlaceholder(this SitecoreHelper helper, string placeholderName)
		{
			var placeholder = string.Format("{0}_{1}", placeholderName, RenderingContext.Current.Rendering.UniqueId);
			var count = 0;

			if ((count = DynamicPlaceholders.Count(dp => dp.StartsWith(placeholder))) > 0)
			{
				placeholder = string.Format("{0}_{1}", placeholder, count);

				DynamicPlaceholders.Add(placeholder);
			}

			return helper.Placeholder(placeholder);
		}
	}
}
