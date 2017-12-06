using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace menu
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<IShape>();
            int number;
            do
            {
                Console.WriteLine("Please input number:");
                Console.WriteLine("1. for cicle: ");
                Console.WriteLine("2. for rectangle :");
                Console.WriteLine("3. show shapes :");
                Console.WriteLine("0. exit");
                number = int.Parse(Console.ReadLine());
                switch (number)
                {
                    case 0:
                        break;
                    case 1:
                        Console.Write("R= ");
                        double r = double.Parse(Console.ReadLine());
                        shapes.Add(new circle(r));
                        break;
                    case 2:
                        Console.Write("A= ");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write("B= ");
                        double b = double.Parse(Console.ReadLine());
                        shapes.Add(new rectangle(a, b));
                        break;
                    case 3:
                        foreach (var shape in shapes)
                        {
                            Console.WriteLine("The area is: {0}", shape.area());
                        }
                        break;
                    case 4:
                        using (var fs = new FileStream("shapes.bin", FileMode.Create))
                        {
                            foreach(var s in shapes)
                            {
                                var shBytes = s.Serilaze();
                                fs.Write(shBytes, 0, shBytes.lenght);
                            }
                        }
                        break;
                            default:
                        Console.WriteLine("Wrong num");
                        break;
                }
            }
            while (number != 0);
        }
    }
}
