using Sitecore.Mvc.Helpers;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DynamicPlaceholders.Mvc.Extensions
{
	public static class SitecoreHelperExtensions
	{
		public static HtmlString DynamicPlaceholder(this SitecoreHelper helper, string placeholderName)
		{
			var currentRenderingId = RenderingContext.Current.Rendering.UniqueId;

			return helper.Placeholder(string.Format("{0}_{1}", placeholderName, currentRenderingId));
		}
	}
}
