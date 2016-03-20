using System.Web.Optimization;
using BundleTransformer.Core.Builders;
using BundleTransformer.Core.Orderers;
using BundleTransformer.Core.Resolvers;
using BundleTransformer.Core.Transformers;

namespace tshirt.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            var nullBuilder = new NullBuilder();
            var styleTransformer = new StyleTransformer();
            var scriptTransformer = new ScriptTransformer();
            var nullOrderer = new NullOrderer();

            BundleResolver.Current = new CustomBundleResolver();
            var commonStylesBundle = new Bundle("~/Bundles/CommonStyles");
            commonStylesBundle.IncludeDirectory("~/css/","*.css",true);
            commonStylesBundle.IncludeDirectory("~/css/","*.scss",true);
            commonStylesBundle.Builder = nullBuilder;
            commonStylesBundle.Transforms.Add(styleTransformer);
            commonStylesBundle.Orderer = nullOrderer;
            bundles.Add(commonStylesBundle);


            var modernizrBundle = new Bundle("~/Bundles/Modernizr");
            modernizrBundle.Include("~/Scripts/modernizr-*");
            modernizrBundle.Builder = nullBuilder;
            modernizrBundle.Transforms.Add(scriptTransformer);
            modernizrBundle.Orderer = nullOrderer;
            bundles.Add(modernizrBundle);


            var commonScriptsBundle = new Bundle("~/Bundles/CommonScripts");
            commonScriptsBundle.Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/jquery.validate*",
                "~/Scripts/bootstrap.js",
                "~/Scripts/respond.js"
                );
            commonStylesBundle.Builder = nullBuilder;
            commonScriptsBundle.Transforms.Add(scriptTransformer);
            commonScriptsBundle.Orderer = nullOrderer;
            bundles.Add(commonScriptsBundle);
        }
    }
}