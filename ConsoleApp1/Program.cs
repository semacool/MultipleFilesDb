using ConsoleApp1;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var testLogic = new TestLogic();
            testLogic.Start();

            Console.ReadLine();
        }
    }
}
