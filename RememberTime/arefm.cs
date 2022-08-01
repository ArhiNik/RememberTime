﻿using System;
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

        //3.4.
        public void applArefm()
        {
            Console.Write("Введите кол-во учеников: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во яблок: ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"По {k/N} яблок досталось ученикам\n{k%N} осталось яблок в корзине");
        }

        //3.5.
        public void coubArefm()
        {
            int sum = 543 / 130;
            Console.WriteLine($"В прямоугольник размером 543х130мм можно вписать {sum} квадрата с размером сторон 130мм");
        }

        //3.9.
        public void sutkyArefm()
        {
            Console.Write("Введите  сколько секунд прошло с начало суток (макс. знач. - 86399сек.): ");
            int time = Convert.ToInt32(Console.ReadLine());

            if (time < 86400 && time > 0)
            {
                int chas = time / 3600;
                int minsut = time / 60;
                int minchas = minsut - chas * 60;
                int secmin = time - minchas * 60 - chas * 3600;
                Console.WriteLine($"сколько полных часов прошло с начала суток: {chas}" +
                    $"\nсколько полных минут прошло с начала очередного часа: {minchas}" +
                    $"\nсколько полных секунд прошло с начала очередной минуты: {secmin}");
            }
        }
    }
}
