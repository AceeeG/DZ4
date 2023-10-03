using System;
using System.Configuration;
using System.Diagnostics;
using System.Threading;

namespace Exercises
{
    internal class Program
    {
        static int CalculateAVG(params int[] nums)
        {
            int sum = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                sum += nums[i]; 
            }
            
            int result = sum / nums.Length;
            return sum;
            
            
            //Console.WriteLine($"Среднее арифметическое массива равна {result}\n");
        }
        static void Main(string[] args)
        {
            /*
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
                $"{array[16]}, {array[17]}, {array[18]}, {array[19]}\n");
            Console.WriteLine("Упражнение 2 - метод находящий среднее арифметическое значение массива\n");
            CalculateAVG(array);
            */
            
            Console.WriteLine("Задание 3\nВведите цифру от 0 до 9\nИли напишите exit или закрыть, чтобы выйти\n");
            int num = 0;
            bool flag = false;
            
            try
            {
                flag = Int32.TryParse(Console.ReadLine().ToLower(), out num);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Вы ввели не число\nПовторите");
                string text = Console.ReadLine().ToLower();
                if (text != "exit" || text != "закрыть") 
                {
                    flag = Int32.TryParse(text, out num);
                    while (flag == false || text != "exit" || text != "закрыть")
                    {
                        Console.WriteLine("Вы ввели не число\nПовторите");
                        text = Console.ReadLine().ToLower();
                        flag = Int32.TryParse(text, out num);
                    }
                }
            }
               
            if (flag)
            {
                switch (num)
                {
                    case 0:
                        Console.WriteLine("###\n# #\n# #\n# #\n###");
                        break;
                    case 1:
                        Console.WriteLine(" # \n # \n #\n # \n # ");
                        break;
                    case 2:
                        Console.WriteLine("###\n  #\n # \n#  \n###");
                        break;
                    case 3:
                        Console.WriteLine("###\n  #\n###\n  #\n###");
                        break;
                    case 4:
                        Console.WriteLine("# #\n# #\n# #\n  #\n  #");
                        break;
                    case 5:
                        Console.WriteLine("###\n#  \n###\n  #\n###");
                        break;
                    case 6:
                        Console.WriteLine("###\n#  \n###\n# #\n###");
                        break;
                    case 7:
                        Console.WriteLine("###\n  #\n #\n#  \n#  ");
                        break;
                    case 8:
                        Console.WriteLine("###\n# #\n###\n# #\n###");
                        break;
                    case 9:
                        Console.WriteLine("###\n# #\n###\n #\n###");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.WriteLine("ААААААААА число не от 0 до 9\n");
                        Thread.Sleep(3000);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        break;

                }
                
            }
            else
            {
                Process.GetCurrentProcess().Kill();
            }


            Console.ReadKey();
        }
    }
}
