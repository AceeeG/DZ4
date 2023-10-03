using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнения 1 - 4\nУпражнение 1\n");
            Random random = new Random();
            int[] array = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(10000);
            }
            Console.WriteLine($"Элементы массива: {array[0]}, {array[1]}, {array[2]}, {array[3]}, {array[4]}, {array[5]}, {array[6]}, {array[7]}," +
                $" {array[8]},{array[9]}, {array[10]}, {array[11]}, " +
                $"{array[12]}, {array[13]}, {array[14]}, {array[15]}, " +
                $"{array[16]}, {array[17]}, {array[18]}, {array[19]}\nВведите два числа из этого массива, которые хотите поменять местами\n" +
                $"Введите первое число\n");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число\n");
            int num2 = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == num1)
                    array[i] = num2;
                else if (array[i] == num2)
                    array[i] = num1;
                else
                    array[i] = array[i];
            }
            Console.WriteLine($"Новый массив: {array[0]}, {array[1]}, {array[2]}, {array[3]}, {array[4]}, {array[5]}, {array[6]}, {array[7]}," +
                $" {array[8]},{array[9]}, {array[10]}, {array[11]}, " +
                $"{array[12]}, {array[13]}, {array[14]}, {array[15]}, " +
                $"{array[16]}, {array[17]}, {array[18]}, {array[19]}");

            Console.ReadKey();
        }
    }
}
