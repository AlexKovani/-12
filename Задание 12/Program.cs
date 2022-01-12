using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_12
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Привет! Я калькулятор параметров окружности!");
            Console.WriteLine("Что хотите вычислить?");
            Console.WriteLine("1 - Длину\r\n2 - Площадь\r\n3- Принадлежность точки с координатома х и у");
            Console.Write("Введите значение: ");
            int vvod;
            try
            {
                vvod = Convert.ToInt32(Console.ReadLine());
                if (vvod <= 0 || vvod >3)
                {
                    Console.WriteLine("Вы ввели неверное число!");
                }
                switch (vvod)
                {
                    case 1:
                        {
                            Console.Write("Введите радиус: ");
                            int r = Convert.ToInt32(Console.ReadLine());
                            Circle.Length(r);

                            break;
                        }
                    case 2:
                        {
                            Console.Write("Введите радиус: ");
                            int r = Convert.ToInt32(Console.ReadLine());
                            Circle.Square(r);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Введите координаты точки через Enter: ");
                            int x1 = Convert.ToInt32(Console.ReadLine());
                            int y1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите координаты центра окружности через Enter: ");
                            int x2 = Convert.ToInt32(Console.ReadLine());
                            int y2 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Введите радиус: ");
                            int r = Convert.ToInt32(Console.ReadLine());
                            Circle.Points(x1, x2, y1, y2, r);
                            break;
                        }
                    default:
                        break;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);

            }
            Console.ReadKey();

        }
    }
}
