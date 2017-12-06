using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameQueue = new Queue1();
            string name = "a";
            while (name != string.Empty)
            {
                name = Console.ReadLine();
                nameQueue.Push(name);
            }

            while (!nameQueue.Empty)
            {
                string names = nameQueue.Pop();
                Console.WriteLine(names);
            }
        }
    }
}
