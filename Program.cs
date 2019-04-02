using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldDemoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(args.Length);
            try
            {
                //Console.WriteLine($"Hello {args[1]}");
                //Console.WriteLine("Super, kein Fehler");
                //Console.Read();
                //Console.WriteLine();
                

            }
            catch (UnauthorizedAccessException UAE)
            {
                Console.WriteLine("Sie haben keine Berechtigung den Ordner zu erstellen.");
            }

            catch (Exception ex)
            {
                throw new DemoException("test");
            }
            Console.Read();
        }
    }

    public class DemoException : Exception
    {
        public DemoException(string message)
        {

        }

        public DemoException()
        {

        }
    }
}
