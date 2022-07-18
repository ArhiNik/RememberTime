using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RememberTime
{
    class output
    {

        //1.6.
        public void piOutput()
        {
            Console.WriteLine("Число Пи ровна: ");
            double pi = Math.PI;
            Console.WriteLine(Math.Round(pi, 3));
        }

        //1.8.
        public void readOutput()
        {
            Console.Write("Вы ввели число ");
            int digit = Convert.ToInt32(Console.ReadLine());
        }

        //1.13.
        public void backOutput()
        {
            Console.Write("Введите число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            
            int a = b - 1;
            int c = b + 1;

            Console.Write($"Предыдущее число: {a}\nВпередистоящее число: {c}");
        }

        //1.14.
        public void splitOutput()
        {
            Console.WriteLine("Введите 3 числа через пробел: ");
            string str = Console.ReadLine();
            string[] splitStr = str.Split(' ');

            Console.Write("Вы ввели: ");
            foreach (var sStr in splitStr)
            {
                Console.Write(sStr+" ");
            }

            Console.ReadKey();
        }

        //1.15.
        public void spOutput()
        {
            Console.WriteLine("Введите 4 числа через пробел: ");
            string str = Console.ReadLine();
            string[] spStr = str.Split(' ');

            Console.Write("Вы ввели: ");
            foreach (var sStr in spStr)
            {
                Console.Write(sStr+" ");
            }
        }
    }
}
