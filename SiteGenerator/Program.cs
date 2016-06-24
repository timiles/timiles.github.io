using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security;
using System.Security.Permissions;

namespace SiteGenerator
{
    class Program
    {
        static int Main(string[] args)
        {
            // Ensure we run in second AppDomain so RazorEngine can clean up temp files on Unload
            if (AppDomain.CurrentDomain.IsDefaultAppDomain())
            {
                var domain = AppDomain.CreateDomain("MainAppDomain", null,
                    AppDomain.CurrentDomain.SetupInformation, new PermissionSet(PermissionState.Unrestricted));
                var exitCode = domain.ExecuteAssembly(Assembly.GetExecutingAssembly().Location);
                AppDomain.Unload(domain);
                return exitCode;
            }

            var generatedHtml = HtmlGenerator.Generate(ModelBuilder.GetIndexModel(), "UA-17476465-1");
            File.WriteAllText(@"../../index.html", generatedHtml);
            Process.Start("chrome.exe", "http://www.timiles.local/");
            return 0;
        }
    }
}
