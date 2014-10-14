using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyinfo = Console.ReadKey();
            Console.WriteLine(keyinfo.Key + " was pressed");
        }
    }
}
