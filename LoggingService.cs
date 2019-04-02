using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldDemoProject
{
    public class LoggingService
    {

        /// <summary>
        /// Nicht das offensichtliche sondern die Absicht dahinter
        /// Soll einen Eintrag in die Infos.log anhängen
        /// </summary>
        /// <param name="toLog">Wird als neue Zeile angehängt</param>
        public void Log(string toLog)
        {
            var path = (string)Environment.GetEnvironmentVariables()["APPDATA"];
            var folder = Path.Combine(path, "SageAT");
            Directory.CreateDirectory(folder);
            var logFile = Path.Combine(folder, "Infos.log");

            using (var sw = new StreamWriter(logFile, append: true))
            {
                sw.WriteLine(toLog);
            }
        }
    }
}
