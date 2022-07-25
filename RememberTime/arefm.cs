using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RememberTime
{
    internal class arefm
    {
        //3.1.
        public void santimArefm()
        {
            Console.Write("Введите длину расстояния в сантиметрах: ");
            int santimetr = Convert.ToInt32(Console.ReadLine());

            int metr = santimetr / 100;

            Console.WriteLine("Число полных метров: "+metr);
        }

        //3.3.
        public void dayArefm()
        {
            int nedeli = 234 / 7;
            Console.WriteLine($"После 234 дней прошло {nedeli} недель");
        }

    }
}
