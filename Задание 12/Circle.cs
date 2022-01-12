using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_12
{
    // Разработать статический класс для работы с окружностью.Класс должен содержать 3 метода:
    // метод, определяющий длину окружности по заданному радиусу;
    // метод, определяющий площадь круга по заданному радиусу;
    // метод, проверяющий принадлежность точки с координатами(x, y) кругу с радиусом r и координатами центра x0, y0.
    static class Circle
    {
      
        public static void Length(int r)  //длинa C = 2 * PI * r
        {
            if (r > 0)
            {
                double C = 2 * Math.PI * r;
                Console.WriteLine("Длина окружности = {0}", C);
            }
            else
            {
                if (r < 0)
                {
                    Console.WriteLine("Значение радиуса должно быть больше 0!");
                }
                if (r == 0)
                {
                    Console.WriteLine("Радиус = 0. Это точка. Попробуйте увеличить значение радиуса!");
                }
            }
        }

        public static void Square(int r) //площадь S = PI*r^2
        {
            if (r > 0)
            {
                double S = Math.PI * Math.Pow(r, 2);
                Console.WriteLine("Длина круга = {0}", S);
            }
            else
            {
                if (r < 0)
                {
                    Console.WriteLine("Значение радиуса должно быть больше 0!");
                }
                if (r == 0)
                {
                    Console.WriteLine("Радиус = 0. Это точка. Попробуйте увеличить значение радиуса!");
                }
            }
           
        }

        public static void Points(int x1, int x2, int y1, int y2, int r)  //точкa с координатами x1, y1 
        {
            double a = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + r);
            if (a < r)
            {
                Console.WriteLine("Точка принадлежит данному кругу!");
            }
            else
            {
                Console.WriteLine("Точка не принадлежит данному кругу!");
            }
        }
    }
}
