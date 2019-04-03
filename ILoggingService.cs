using System.Collections.Generic;

namespace HelloWorldDemoProject
{
    public interface ILoggingService
    {
        void DeleteLine(int rowIndex);
        void Log(string toLog);
        List<string> Readlog();
    }
}