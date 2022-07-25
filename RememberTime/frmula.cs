using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RememberTime
{
    internal class frmula
    {
        //2.1.
        public void disFrmula()
        {
            Console.Write("Введите х: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(17 * x * x - 6 * x + 13);
        }

        //2.2.
        public void corFrmula()
        {
            Console.Write("Введите a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((a*a + 10)/(Math.Sqrt(a*a+1)));
        }

        //2.3.
        public void sinFrmula()
        {
            Console.Write("Введите a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            
            double sum = Math.Sqrt((2 * a + Math.Sin(Math.Abs(3*a)))/3.56);

            Console.WriteLine(sum);
        }

        //2.4.
        public void kvFrmula()
        {
            Console.Write("Введите сторону квадрата: ");
            double storon = Convert.ToDouble(Console.ReadLine());

            double perym = storon * 4;
            
            Console.WriteLine("Периметор квадрата равен: "+ perym);
        }

        //2.5.
        public void okrFrmula()
        {
            Console.Write("Введите радиус окружности: ");
            double radyus = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(radyus*2); 
        }

        //2.6.
        public void gorizFrmula()
        {
            Console.Write("Радиос планеты Земля примерно равен: 6350 км\nВведите точку высоты h: ");
            double h = Convert.ToInt32(Console.ReadLine());
            int R = 6350;

            double line = (R+h)*(R+h)-(R*R);
            line = Math.Sqrt(line);
            Console.WriteLine($"Ростояние от точки наблюдения {h} до линии горизонта равна: {Math.Round(line, 3)}");
        }


    }
}
