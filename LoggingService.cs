using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldDemoProject
{
    public class LoggingService : ILoggingService, ILoggingService1, IInitLogging
    {
        public string logFile;
        private int counter;


        public void init()
        {
        string path = (string)Environment.GetEnvironmentVariables()["APPDATA"];
        string folder = Path.Combine(path, "SageAT");
            Directory.CreateDirectory(folder);
            logFile = Path.Combine(folder, "Infos.log");
            counter = 0;
        }


        /// <summary>
        /// Nicht das offensichtliche sondern die Absicht dahinter
        /// Soll einen Eintrag in die Infos.log anhängen
        /// </summary>
        /// <param name="toLog">Wird als neue Zeile angehängt</param>
        /// 

        #region ILoggingService
        public void Log(string toLog)
        {

            using (var sw = new StreamWriter(logFile, append: true))
            {
                sw.WriteLine(counter.ToString() + " " + toLog);
            }
            counter++;
        }

        public void DeleteLine(int rowIndex)
        {
            var list = new List<string>();
            using (var sr = new StreamReader(logFile))
            {
                while (!sr.EndOfStream)
                {
                    list.Add(sr.ReadLine());
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                var islinetodelete = list[i].StartsWith(rowIndex.ToString());
                if (islinetodelete)
                {
                    list.RemoveAt(i);
                    break;
                }
            }
            using (var sw = new StreamWriter(logFile, append: false))
            {
                foreach (var line in list)
                {
                    sw.WriteLine(line);
                }

            }
        }



        public List<string> Readlog()
        {
            var list = new List<string>();
            using (var sr = new StreamReader(logFile))
            {
                while (!sr.EndOfStream)
                {
                    list.Add(sr.ReadLine());
                }
            }
            return list;
        }
        #endregion ILoggingService
    }
}
