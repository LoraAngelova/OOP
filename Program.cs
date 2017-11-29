using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumber
{
    class Number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете число ");
            int number = 0;
            int counter = 0;
            var rand = new Random();
            int randomNumber = rand.Next(1, 101);
            do
            {
                number = int.Parse(Console.ReadLine());
                counter++;

                if (number > randomNumber)
                {
                    Console.WriteLine("надолу");
                }

                else if (number < randomNumber)
                {
                    Console.WriteLine("нагоре");
                }

                if (number == randomNumber)
                {
                    Console.WriteLine("Ти позна числото");
                    Console.WriteLine("Ти го позна от {0} път ", counter);
                }
            } while (number != randomNumber);

            {

            }
        }
    }
}
