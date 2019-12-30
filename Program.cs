using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = DataManager.Instance.GetData();
            Console.WriteLine(data);
            Console.ReadKey();

        }
    }
}
