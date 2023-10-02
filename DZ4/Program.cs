using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DZ4
{
    internal class Program
    {
        static void Maxim(int a, int b)
        {
            int result = Math.Max(a, b);
            if (a == b)
            {
                Console.WriteLine("Числа равны");
            }
            else 
            {
                Console.WriteLine($"{result} максимальное из этих двух\n");
            }

        }

        static void Swap(int num1, int num2)
        {
            int swapnum = num1;
            num1 = num2;
            num2 = swapnum;
            Console.WriteLine($"Теперь первое число равно {num1}, а второе {num2}\n");

        }

        static void Factorial(out int i)//через цикл, так как следующее задание требуют через рекурсию
        {
            int maxvalue = int.MaxValue;
            int f = Convert.ToInt32(Console.ReadLine());
            for (int j = f - 1; j > 1; j--)
            {
                    f = f * j;
            }

            i = f;

            Console.WriteLine($"Факториал  =  {f}");

            try
            {
                int z = checked(maxvalue + f);
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine("CHECKED " + e.ToString() + "\n");
            }

        }
        static int Recursive_Fac(int num)//через рекурсию
        {
            if (num == 1 || num == 0)
            {
                return 1;
            }
            else
            {
                return num * Recursive_Fac(num - 1);
            }
        }
        static int NOD(int a, int b)
        {
            if (a != 0 && b != 0)
            {
                while (a != 0 && b != 0)
                {
                    if (Math.Abs(a) > Math.Abs(b))
                        a = a % b;
                    else
                        b = b % a;
                }
                return a + b;
            }
            else
                return a + b;
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Лабораторная 5\nУпражнение 1- тест метода выводящий максимальное значение\nВведите первое число: \n");
            int a  = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: \n");
            int b = Convert.ToInt32(Console.ReadLine());
            Maxim(a, b);
            Console.WriteLine("Упражнение 2\nВведите 1 число\n");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2 число\n");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Swap(num1, num2);
            Console.WriteLine("Упранение 3 - поиск факториала\nВведите целое число\n");
            int f;
            Factorial(out f);
            Console.WriteLine("Упражнение 4 - поиск факториала программой, написанной рекурсивным способом\nВведите целое число: \n");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Факториал = {Recursive_Fac(num)}");
            


            Console.WriteLine("Домашнее задание 1 - метод для нахождения НОД\nВведите 1 число\n");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2 число\n");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Наибольший общий делитель для чисел {a1} и {b1} это: {NOD(a1, b1)}\n");



            Console.ReadKey();
        }
    }
}
