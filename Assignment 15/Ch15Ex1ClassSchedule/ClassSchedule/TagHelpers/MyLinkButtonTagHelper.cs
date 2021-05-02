using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Routing;

namespace ClassSchedule.TagHelpers
{
    public class MyLinkButtonTagHelper : TagHelper
    {
        private LinkGenerator linkGenerator;
        public MyLinkButtonTagHelper(LinkGenerator linkGen) => linkGenerator = linkGen;

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewCtx { get; set; }

        public string Action { get; set; }
        public string Controller { get; set; }
        public string Id { get; set; }
        public bool IsActive { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string action = Action ?? ViewCtx.RouteData.Values["action"].ToString();
            string controller = Controller ?? ViewCtx.RouteData.Values["controller"].ToString();
            var segment = (string.IsNullOrEmpty(Id)) ? null : new { Id };

            string url = linkGenerator.GetPathByAction(action, controller, segment);
            string css = (IsActive) ? "btn btn-dark" : "btn btn-outline-dark";

            output.BuildLink(url, css);
        }
    }
}
