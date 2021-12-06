using System;
using System.Configuration;



namespace config_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConfigurationManager.AppSettings["test"]);
        }
    }
}
