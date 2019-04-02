using System;
using System.Collections.Generic;
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
                Console.WriteLine($"Hello {args[1]}");
                Console.WriteLine("Super, kein Fehler");
                Console.Read();
            }
            //catch (IndexOutOfRangeException IOORE) //when (IOORE.Message.Contains("Index"))
            //{
            //    Console.WriteLine(IOORE.Message);
            //}

            catch (Exception)
            {

                //throw new DemoException("");
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
