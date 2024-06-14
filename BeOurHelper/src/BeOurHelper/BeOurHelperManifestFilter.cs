using Umbraco.Cms.Core.Manifest;

namespace Umbraco.Community.BeOurHelper
{
    internal class BeOurHelperManifestFilter : IManifestFilter
    {
        public void Filter(List<PackageManifest> manifests)
        {
            var assembly = typeof(BeOurHelperManifestFilter).Assembly;

            manifests.Add(new PackageManifest
            {
                PackageName = "BeOurHelper",
                Version = assembly.GetName()?.Version?.ToString(3) ?? "0.1.0",
                AllowPackageTelemetry = true,
                Scripts = new string[] {
                    // List any Script files
                    // Urls should start '/App_Plugins/BeOurHelper/' not '/wwwroot/BeOurHelper/', e.g.
                    // "/App_Plugins/BeOurHelper/Scripts/scripts.js"
                },
                Stylesheets = new string[]
                {
                    // List any Stylesheet files
                    // Urls should start '/App_Plugins/BeOurHelper/' not '/wwwroot/BeOurHelper/', e.g.
                    // "/App_Plugins/BeOurHelper/Styles/styles.css"
                }
            });
        }
    }
}
