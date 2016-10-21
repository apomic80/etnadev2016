using Microsoft.AspNetCore.Razor.TagHelpers;

namespace EtnaDev.ViewComponents
{
    [HtmlTargetElement("div", Attributes = LatitudeAttributeName)]
    [HtmlTargetElement("div", Attributes = LongitudeAttributeName)]
    public class GoogleMapsTagHelper : TagHelper
    {
        private const string LatitudeAttributeName = "gm-latitude";
        private const string LongitudeAttributeName = "gm-longitude";

        [HtmlAttributeName(LatitudeAttributeName)]
        public string Latitude { get; set; }

        [HtmlAttributeName(LongitudeAttributeName)]
        public string Longitude { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Content.AppendHtml(
                string.Format(
                    "<iframe style=\"border: 0;\" src=\"https://www.google.com/maps/embed/v1/place?q={0},{1}&key=AIzaSyBVVdNkSZdAHZ1evnizT4CHhTfUuMUaQLM\" width=\"100%\" height=\"450\" frameborder=\"0\" allowfullscreen=\"\"></iframe>",
                    Latitude, Longitude));

            base.Process(context, output);
        }
    }
}