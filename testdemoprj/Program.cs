using System;
using System.Configuration;

namespace testdemoprj
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = ConfigurationManager.AppSettings["email"];
            Console.WriteLine("hello world");
            Console.ReadLine();
        }

        public void sum()
        {
            Program p = new Program();
            Console.WriteLine("Hello GIT");
        }
    }
}
