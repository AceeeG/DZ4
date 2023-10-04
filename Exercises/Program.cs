using System;
using System.Configuration;
using System.Diagnostics;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace Exercises
{
    internal class Program
    {
        enum GrumpyLevel
        {
            Поехавший,
            Ворчун,
            Мужик
        }
        struct Grandpa
        {
            public string name;
            public GrumpyLevel grumpy;
            public string[] swearword;
            public int bruises;
            public void GrandmaPunches(params string[] swearword)
            {
                foreach (string word in swearword)
                {
                    if (Array.IndexOf(swearword, word.ToLower()) != -1)
                    {
                        bruises++;
                    }
                }
            }
            static int CalculateAVG(ref int multiply, out double average, params int[] array)
            {
                int sum = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                    multiply *= array[i];
                }

                average = (double)sum / array.Length;

                return sum;
            }

            static void DrawNumbers(int number)
            {
                switch (number)
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
                for (int i = 0; i < array.Length; i++)
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
                int multiply = 1;
                double average = 0;
                CalculateAVG(ref multiply, out average, array);
                Console.WriteLine($"Произведение элементов массива - {multiply}, среднее значение - {average}\n");

                Console.WriteLine("Задание 3\nВведите цифру от 0 до 9\nИли напишите exit или закрыть, чтобы выйти\n");
                string text = Console.ReadLine();
                bool flag;
                int number;
                try
                {
                    if (text.ToLower() == "exit" || text.ToLower() == "закрыть")
                        Process.GetCurrentProcess().Kill();
                    else
                    {
                        number = Convert.ToInt32(text);
                        DrawNumbers(number);
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Вы не ввели целое число");
                    do
                    {
                        text = Console.ReadLine();
                        flag = int.TryParse(text, out number);

                        if (flag)
                        {
                            DrawNumbers(number);
                        }
                        else if (text.ToLower() == "exit" || text.ToLower() == "закрыть")
                        {
                            Process.GetCurrentProcess().Kill();
                        }
                        else
                        {
                            Console.WriteLine("Вы не ввели целое число");
                        }
                    } while (!(text.ToLower() == "exit" || text.ToLower() == "закрыть"));
                }

                Console.WriteLine("4 задание - деды ругаются матом.\n");

                Grandpa Anzor = new Grandpa();
                string anzor_name = "Анзор";
                GrumpyLevel anzor_grumpy = GrumpyLevel.Поехавший;
                string[] anzor_swearword = { "Дурной п#№ды ребенок", "Я твой роутер е№@*", "Инвалид еба№#%ый", "Сын шайки фашистов" };
                int anzor_bruises = 0;
                Anzor.GrandmaPunches(Anzor.swearword);


                Grandpa Vahid = new Grandpa();
                string vahid_name = "Вахид";
                GrumpyLevel vahid_grumpy = GrumpyLevel.Ворчун;
                string[] vahid_swearword = { "Ошпарил х№#", "Ва#$%@льный дебошир", };
                int vahid_bruises = 0;
                Vahid.GrandmaPunches(Vahid.swearword);

                Grandpa Abdulbori = new Grandpa();
                string abdulbori_name = "Абдулборий";
                GrumpyLevel abdulbori_grumpy = GrumpyLevel.Поехавший;
                string[] abdulboru_swearword = { "Таких бл#@! убивал в своё время", "Под шконку н$@#й", "Я вам кадыки сломаю", "Вы б№@ знаете какие я темки мутил в молодости" };
                int abdulboru_bruises = 0;
                Abdulbori.GrandmaPunches(Abdulbori.swearword);

                Grandpa Serdzhua = new Grandpa();
                string serdzhua_name = "Серджуа";
                GrumpyLevel serdzhua_grumpy = GrumpyLevel.Мужик;
                string[] serdzhua_swearword = { };
                int serdzhua_bruises = 0;
                Serdzhua.GrandmaPunches(Serdzhua.swearword);

                Grandpa Sherhan = new Grandpa();
                string sherhan_name = "Шерхан";
                GrumpyLevel sherhan_grumpy = GrumpyLevel.Мужик;
                string[] sherhan_swearword = { };
                int sherhan_bruises = 0;
                Sherhan.GrandmaPunches(Sherhan.swearword);
                Console.WriteLine($"У деда {Anzor.name} {Anzor.bruises} фингалов.\n" +
                    $"У деда {Vahid.name} {Vahid.bruises} фингалов.\n" +
                    $"У деда {Abdulbori.name} {Abdulbori.bruises} фингалов.\n" +
                    $"У деда {Serdzhua.name} {Serdzhua.bruises} фингалов." +
                    $"У деда {Sherhan.name} {Sherhan.bruises} фингалов.\n\n");


                Console.ReadKey();
            }
        }
    }
}
