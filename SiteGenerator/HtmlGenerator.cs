using RazorEngine;
using RazorEngine.Configuration;
using RazorEngine.Templating;
using RazorEngine.Text;
using SiteGenerator.Models;

namespace SiteGenerator
{
    class HtmlGenerator
    {
        public static string Generate(IndexModel indexModel, string googleAnalyticsTrackingCode = null)
        {
            var config = new TemplateServiceConfiguration
            {
                TemplateManager = new EmbeddedResourceTemplateManager(typeof(Program)),
                EncodedStringFactory = new RawStringFactory()
            };
            Engine.Razor = RazorEngineService.Create(config);

            var viewBag = new DynamicViewBag();
            viewBag.AddValue("GoogleAnalyticsTrackingCode", googleAnalyticsTrackingCode);
            return Engine.Razor.RunCompile("Templates.Index", model: indexModel, viewBag: viewBag);
        }
    }
}