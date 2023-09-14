using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свой возраст");
            string txt = Console.ReadLine();
            double num = Convert.ToInt32(txt);
            if (double.TryParse(txt, out num) == true)
        if (num > 100)
        {
                    Console.WriteLine(txt );
                    EventLogSession IF = new EventLogSession(num + txt);
        }
            
            
           
            if (num < 0)
                Console.WriteLine(" Возраст не может быть отрицательным ");
            else
            {
                num = num + 23;
                Console.WriteLine("Вам будет " + num + " черезм 23 года вом будет ");
            }
            Console.ReadKey();
        }
    }
}
