using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DZ4
{
    internal class Program
    {
        static void CalculateMaxim(int a, int b)
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

        static void CalculateFactorial(out int i)//через цикл, так как следующее задание требуют через рекурсию
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
        static int CalculateRecursive_Fac(int num)//через рекурсию
        {
            if (num == 1 || num == 0)
            {
                return 1;
            }
            else
            {
                return num * CalculateRecursive_Fac(num - 1);
            }
        }
        static int GetNOD(int a, int b)
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
        static int GetNOD(int a, int b, int c)
        {
            if ((a != 0 && b != 0 && c != 0))
                return GetNOD(GetNOD(a, b), c);
            else
                return a + b + c;
        }

        static int GetFib(int n)
        {
            int[] array = new int[100];
            if (n <= 1)
                return 1;
            else if (array[n] != 0)
                return array[n];
            array[n] = GetFib(n - 2) + GetFib(n - 1);
            return array[n];
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Лабораторная 5\nУпражнение 1- тест метода выводящий максимальное значение\nВведите первое число: \n");
            int a  = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: \n");
            int b = Convert.ToInt32(Console.ReadLine());
            CalculateMaxim(a, b);
            Console.WriteLine("Упражнение 2\nВведите 1 число\n");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2 число\n");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Swap(num1, num2);
            Console.WriteLine("Упранение 3 - поиск факториала\nВведите целое число\n");
            int f;
            CalculateFactorial(out f);
            Console.WriteLine("Упражнение 4 - поиск факториала программой, написанной рекурсивным способом\nВведите целое число: \n");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Факториал = {CalculateRecursive_Fac(num)}");
            


            Console.WriteLine("Домашнее задание 1 - метод для нахождения НОД\nВведите 1 число\n");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2 число\n");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Наибольший общий делитель для чисел {a1} и {b1} это: {GetNOD(a1, b1)}\n");
            Console.WriteLine("Теперь проверим метод для 3 чисел\nВведите 1 число:\n");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2 число:\n");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 3 число:\n");
            int number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Наибольший общий делитель для чисел {number1}, {number2} и {number3} это {GetNOD(number1, number2, number3)}\n");
            Console.WriteLine("Домашнее задание 2 - вычисление н-ного числа в ряде Фибоначчи\nВведите номер числа который хотите найти:\n");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Числом под номером {n} является {GetFib(n)}");


            Console.ReadKey();
        }
    }
}
