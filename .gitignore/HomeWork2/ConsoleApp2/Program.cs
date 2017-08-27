using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            First();
            Second();
            Third();
            Fourth();
            Fifth();
            Sixth();
            Seventh();
            Eighth();
            Ninth();
            Tenth();
        }

        static void First()
        {
            Console.WriteLine("1е задание.");
            Console.WriteLine("3  4  5");
            Console.ReadLine();
        }

        static void Second()
        {
            Console.WriteLine("2е задание.");
            Console.WriteLine("5");
            Console.WriteLine("10");
            Console.WriteLine("21");
            Console.ReadLine();
        }

        static void Third()
        {
            Console.WriteLine("3е задание.");
            int tryParser;
            Console.WriteLine("Введите расстояние в сантиметрах");
            string strDistance = Console.ReadLine();
            bool parseIsOk = Int32.TryParse(strDistance, out tryParser);

            if (parseIsOk)
            {
                int intDistance = Int32.Parse(strDistance);
                Console.WriteLine("{0} метров", (intDistance/100));
            }
            else
            {
                Console.WriteLine("Введенное значение не является целым числом");
            }
            
            Console.ReadLine();
        }

        static void Fourth()
        {
            Console.WriteLine("4е задание.");
            Console.WriteLine("В 234 днях " + 234 / 7 + " полных недель.");
            Console.ReadLine();
        }

        static void Fifth()
        {
            Console.WriteLine("5е задание.");
            Console.WriteLine("Введите двузначное число: ");
            string strNumber = Console.ReadLine();
            int number;
            bool parseIsOkey = Int32.TryParse(strNumber, out number);

            if (parseIsOkey)
            {
                number = Int32.Parse(strNumber);
                Console.WriteLine("a) " + (number / 10));
                Console.WriteLine("b) " + (number % 10));
                Console.WriteLine("c) " + (number / 10 + number % 10));
                Console.WriteLine("c) " + ((number / 10) * (number % 10)));
            }
            else
            {
                Console.WriteLine("Введенное значение не является целым числом");
            }

            Console.ReadLine();
        }

        static void Sixth()
        {
            Console.WriteLine("6е задание.");
            bool a = true;
            bool b = false;
            bool c = false;

            Console.WriteLine("a) " + (a || b));
            Console.WriteLine("b) " + (a && b));
            Console.WriteLine("c) " + (b || c));
            Console.ReadLine();
        }

        static void Seventh()
        {
            Console.WriteLine("7е задание.");
            Console.WriteLine("Введите радиус круга: ");
            string strRadius = Console.ReadLine();
            int r = Int32.Parse(strRadius);

            Console.WriteLine("Введите сторону квадрата: ");
            strRadius = Console.ReadLine();
            int a = Int32.Parse(strRadius);

            if (a * a > 3.14 * r * r)
            {
                Console.WriteLine("Площадь квадрат " + (a * a) + " больше площади круга " + (3.14 * r * r) );
            }
            else
            {
                Console.WriteLine("Площадь круга " + (3.14 * r * r) + " больше площади квадрат " + (a * a) );
            }
            Console.ReadLine();
        }

        static void Eighth()
        {
            Console.WriteLine("8е задание.");
            Console.WriteLine("Введите объем первого материала: ");
            string str = Console.ReadLine();
            double volumeOfFirstMaterial = Int32.Parse(str);

            Console.WriteLine("Введите массу первого материала: ");
            str = Console.ReadLine();
            double massOfFirstMaterial = Int32.Parse(str);

            Console.WriteLine("Введите объем второго материала: ");
            str = Console.ReadLine();
            double volumeOfSecondMaterial = Int32.Parse(str);

            Console.WriteLine("Введите массу второго материала: ");
            str = Console.ReadLine();
            double massOfSecondMaterial = Int32.Parse(str);

            if ((massOfFirstMaterial / volumeOfFirstMaterial) > (massOfSecondMaterial / volumeOfSecondMaterial))
            {
                Console.WriteLine("Плотность первого материала " + (massOfFirstMaterial / volumeOfFirstMaterial) +
                    " больше плотности второго материала " + (massOfSecondMaterial / volumeOfSecondMaterial) );
            }
            else
            {
                Console.WriteLine("Плотность второго материала " + (massOfSecondMaterial / volumeOfSecondMaterial) +
                    " больше плотности первого материала " + (massOfFirstMaterial / volumeOfFirstMaterial) );
            }
            Console.ReadLine();
        }

        static void Ninth()
        {
            Console.WriteLine("9е задание.");
            Console.WriteLine("Введите напряжение первого участка цепи: ");
            string str = Console.ReadLine();
            double voltage_one = Int32.Parse(str);

            Console.WriteLine("Введите сопротивление первого участка цепи: ");
            str = Console.ReadLine();
            double resistance_one = Int32.Parse(str);

            Console.WriteLine("Введите напряжение второго участка цепи: ");
            str = Console.ReadLine();
            double voltage_two = Int32.Parse(str);

            Console.WriteLine("Введите сопротивление второго участка цепи: ");
            str = Console.ReadLine();
            double resistance_two = Int32.Parse(str);

            if ((voltage_one / resistance_one) > (voltage_two / resistance_two))
            {
                Console.WriteLine("Сила тока первого участка цепи " + (voltage_one / resistance_one) +
                    " больше силы тока второго участка цепи " + (voltage_two / resistance_two) );
            }
            else
            {
                Console.WriteLine("Сила тока второго участка цепи " + (voltage_two / resistance_two) +
                    " больше силы тока первого участка цепи " + (voltage_one / resistance_one) );
            }
            Console.ReadLine();
        }

        static void Tenth()
        {
            Console.WriteLine("10е задание.");
            Console.WriteLine("a) ");
            for (int i = 20; i < 35 + 1; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("b) ");
            Console.WriteLine("Введите значение больше 10: ");
            string str = Console.ReadLine();
            int number = Int32.Parse(str);
            for (int i = 10; i < number + 1; i++)
            {
                Console.WriteLine(i * i);
            }

            Console.WriteLine("Введите значение меньшее 50: ");
            str = Console.ReadLine();
            number = Int32.Parse(str);
            for (int i = number; i < 50 + 1; i++)
            {
                Console.WriteLine(i * i * i);
            }

            Console.WriteLine("Введите диапозон, от: ");
            str = Console.ReadLine();
            number = Int32.Parse(str);
            Console.WriteLine("до: ");
            str = Console.ReadLine();
            for (int i = number; i < Int32.Parse(str) + 1; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
