using Cassette;
using Cassette.HtmlTemplates;
using Cassette.Scripts;
using Cassette.Stylesheets;

namespace GoogleMap
{
    public class CassetteConfiguration : IConfiguration<BundleCollection>
    {
        public void Configure(BundleCollection bundles)
        {
            // TODO: Configure your bundles here...
            // Please read http://getcassette.net/documentation/configuration

            // This default configuration treats each file as a separate 'bundle'.
            // In production the content will be minified, but the files are not combined.
            // So you probably want to tweak these defaults!

            bundles.Add<StylesheetBundle>("Content/style.less");
            bundles.Add<StylesheetBundle>("Content/css/font-awesome.css");
            bundles.Add<ScriptBundle>("Scripts/jquery-2.0.3.js");
            bundles.Add<ScriptBundle>("Scripts/jquery-ui-1.10.3.min.js");
            bundles.Add<ScriptBundle>("Scripts/underscore.js");
            bundles.Add<ScriptBundle>("Scripts/backbone.js");
            bundles.Add<ScriptBundle>("Scripts/backbone.marionette.js");
            bundles.Add<ScriptBundle>("Scripts/bootstrap.js");
            bundles.Add<ScriptBundle>("Scripts/base.js");
            bundles.Add<ScriptBundle>("Scripts/app/collections");
            bundles.Add<ScriptBundle>("Scripts/app/controllers");
            bundles.Add<ScriptBundle>("Scripts/app/mixins");
            bundles.Add<ScriptBundle>("Scripts/app/models");
            bundles.Add<ScriptBundle>("Scripts/app/regions");
            bundles.Add<ScriptBundle>("Scripts/app/routers");
            bundles.Add<ScriptBundle>("Scripts/app/views");
            bundles.Add<ScriptBundle>("Scripts/app/GMap.js");
            bundles.Add<HtmlTemplateBundle>("Scripts/app/templates");

            // To combine files, try something like this instead:
            //   bundles.Add<StylesheetBundle>("Content");
            // In production mode, all of ~/Content will be combined into a single bundle.
            
            // If you want a bundle per folder, try this:
            //   bundles.AddPerSubDirectory<ScriptBundle>("Scripts");
            // Each immediate sub-directory of ~/Scripts will be combined into its own bundle.
            // This is useful when there are lots of scripts for different areas of the website.
        }
    }
}