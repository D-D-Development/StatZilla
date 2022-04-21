using System;
using Topshelf;

namespace StatZilla_Services
{
    class Program
    {
        static void Main(string[] args)
        {
            var exitCode = HostFactory.Run( x => {

                x.Service<StatZillaService>(s => {

                    s.ConstructUsing(statzilla => new StatZillaService());
                    s.WhenStarted(statzilla => statzilla.Start());
                    s.WhenStopped(statzilla => statzilla.Stop());

                });

                x.RunAsLocalSystem();
                x.SetServiceName("StatZillaService");
                x.SetDisplayName("StatZilla Service");
                x.SetDescription("This Service Runs along the StatZilla UI," +
                    " It monitors the UI output to manage its own behavior" +
                    " and monitors configured file for updates to begin upload process to various methods.");
            });

            int exitCodeValue = (int)Convert.ChangeType(exitCode, exitCode.GetTypeCode());
            Environment.ExitCode = exitCodeValue;

        }
    }
}
