using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите R: ");
            int R = int.Parse(Console.ReadLine());
            Console.Write("Введите h: ");
            int h = int.Parse(Console.ReadLine());
            double S;
            double V;
            S = Math.PI * Math.Pow(R, 2);
            V = S * h;
            Console.Write($"Объём = {V}");
            Console.ReadKey();

        }
    }
}

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите y: ");
            int y = int.Parse(Console.ReadLine());
            if ((Math.Abs(x) > 1) || (Math.Abs(y) > 1))
            {
                Console.WriteLine("Точка с координатами (x, y) принадлежит области определения");
            }
            else
            {
                Console.WriteLine("Точка с координатами (x, y) не принадлежит области определения");
            }
            Console.ReadKey();
        }
    }
}


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            int max = 0;
            int min = 100000000;
            int[] mas = new int[n];
            int sum;
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next();
            }
            for (int i = 0; i < n; i++)
            {
                if (mas[i] > max)
                {
                    max = mas[i];
                }
                if (mas[i] < min)
                {
                    min = mas[i];
                }
            }
            sum = max + min;
            Console.WriteLine($"Сумма равна = {sum}");
            Console.ReadKey();

        }
    }
}

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            int fib1 = 0;
            int fib2 = 1;
            int fibsum;
            Console.Write(fib1 + " " + fib2 + " ");
            for (int i = 0; i < n - 1; i++)
            {
                fibsum = fib1 + fib2;
                fib1 = fib2;
                fib2 = fibsum;
                Console.Write(fib2 + " ");
            }
            Console.ReadKey();

        }
    }
}


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int x = n % 10;
            do
            {
                if (n % 10 == x)
                {
                    count++;
                }
                n /= 10;
            } while (n != 0);
            Console.Write(count);
            Console.ReadKey();

        }
    }
}

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 31; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    if ((i % 10 == 2) || (i % 10 == 4) || (i % 10 == 8))
                    {
                        sum += i;
                    }
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();

        }
    }
}


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            var dt = new DateTime(c, b, a);
            var bdt = new DateTime(c, 1, 1);

            if ((b == 1 || b == 3 || b == 5 || b == 7 || b == 8 || b == 10 || b == 12) && (a == 0 || a > 31))
            {
                Console.WriteLine("Неверная дата!");
            }
            if ((b == 4 || b == 6 || b == 9 || b == 11) && (a == 0 || a > 30))
            {
                Console.WriteLine("Неверная дата!");
            }
            if ((b == 2) && (a == 0 || a > 28))
            {
                Console.WriteLine("Неверная дата!");
            }
            if ((c % 4 == 0) && (c % 100 != 0) && (c % 400 == 0))
            {
                if ((b == 2) && (a == 0 || a > 29))
                {
                    Console.WriteLine("Неверная дата!");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Сейчас {0}-й день в году", (dt - bdt).Days + 1);
            Console.WriteLine();

            if ((c % 4 == 0) && (c % 100 != 0) && (c % 400 == 0))
            {
                Console.WriteLine("Осталось {0} дней до конца года", 366 - (dt - bdt).Days + 1);
            }

            Console.WriteLine("Осталось {0} дней до конца года", 365 - ((dt - bdt).Days + 1));
            Console.ReadKey();

        }
    }
}

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Введите число, месяц и год в формате xxxx");
            string Number = Console.ReadLine();
            string Mes = Console.ReadLine();
            int Year = int.Parse(Console.ReadLine());
            int Year1 = Year;
            DateTime today = DateTime.Parse($"{Number}.{Mes}.{Convert.ToString(Year)}");
            Console.WriteLine(today);
            while (Year1 > 0)
            {
                Year1 = Year1 - 128;
                count++;
            }
            today = today.AddDays(count);
            Console.WriteLine(today.ToShortDateString());
            Console.ReadKey();

        }
    }
}


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во попыток ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Введите верхнюю границу диапазона рандомных чисел ");
            int n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int r = rnd.Next(1, n);
            int i = 0;

            Console.WriteLine();

            do
            {
                Console.Write("Введите число ");
                int temp = int.Parse(Console.ReadLine());

                if (temp == r)
                {
                    Console.WriteLine("Вы угадали!");
                    break;
                }
                if (temp < r)
                    Console.WriteLine("Больше");
                if (temp > r)
                    Console.WriteLine("Меньше");
                i++;

            } while (i != k);

            Console.WriteLine();
            Console.WriteLine("Игра завершена!");
            Console.ReadKey();

        }
    }
}


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во элементов: ");
            int n = int.Parse(Console.ReadLine());
            int[] mas = new int[n];

            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next();
                Console.WriteLine(mas[i]);
            }
            Console.WriteLine();
            if (mas.Length < 1) return;
            for (int i = 0; i < mas.Length; i++)
            {
                int k = mas[i];
                int rnd = r.Next(i, mas.Length);
                mas[i] = mas[rnd];
                mas[rnd] = k;
                Console.WriteLine(mas[i]);
            }

            Console.ReadKey();

        }
    }
}


namespace ConsoleApp2
{
    class Program
    {
            public static byte rand()
            {
                RNGCryptoServiceProvider r = new RNGCryptoServiceProvider();
                byte[] rnb = new byte[1];
                r.GetBytes(rnb);
                return (rnb[0]);
            }
            static void Main(string[] args)
            {
                for (int i = 0; i < 100; i++)
                {
                    double Random = rand();
                    Console.Write(Random);
                    Console.Write(" ");
                }
                Console.ReadLine();
                Console.ReadKey();
            }
    }
}