using System;
using System.Configuration;
using System.Diagnostics;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace Exercises
{
    internal class Program
    {
        static bool IsItemInArray(int[] array, int value)
        {
            foreach (int item in array)
            {
                if (item == value) return true;
            }
            return false;
        }
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
            public Grandpa(string name, GrumpyLevel grumpy, string[] swearword, int bruises)
            {
                this.name = name;
                this.grumpy = grumpy;
                this.swearword = swearword;
                this.bruises = 0;
            }
            public int GrandmaPunches(params string[] all_swearwords)
            {
                int counter = 0;
                foreach (string word in swearword)
                {
                    foreach (string words in all_swearwords)
                    {
                        if (word.Contains(words)) 
                            counter++;
                    }
                }
                bruises += counter;
                return counter;
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
                if (IsItemInArray(array, num1) && IsItemInArray(array, num2))
                {
                    (array[Array.IndexOf(array, num1)], array[Array.IndexOf(array, num2)]) = (array[Array.IndexOf(array, num2)], array[Array.IndexOf(array, num1)]);
                    Console.WriteLine($"Новый массив: {array[0]}, {array[1]}, {array[2]}, {array[3]}, {array[4]}, {array[5]}, {array[6]}, {array[7]}," +
                                        $" {array[8]},{array[9]}, {array[10]}, {array[11]}, " +
                                        $"{array[12]}, {array[13]}, {array[14]}, {array[15]}, " +
                                        $"{array[16]}, {array[17]}, {array[18]}, {array[19]}\n");
                }
                else
                {
                    Console.WriteLine("Вы ввели числа, которых нет в массивах\n");
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

                string[] anzor_words = { "Дурной п#№ды ребенок", "Я твой роутер е№@*", "Инвалид еба№#%ый", "Сын шайки фашистов", "Су#а" };
                string[] vahid_words = { "Ошпарил х№#", "Ва#$%@льный дебошир", };
                string[] abdulbori_words = { "Таких бл#@! убивал в своё время", "Под шконку н$@#й", "Я вам кадыки сломаю", "Вы б№@ знаете какие я темки мутил в молодости" };
                string[] serdzhua_words = {"Блин"};
                string[] sherhan_words = {"Негодяи"}; //он не получит синяк, так как это безобидное ругательство

                Grandpa Anzor = new Grandpa();
                Anzor.name = "Анзор";
                Anzor.grumpy = GrumpyLevel.Поехавший;
                Anzor.swearword = anzor_words;
                Anzor.bruises = 0;



                Grandpa Vahid = new Grandpa();
                Vahid.name = "Вахид";
                Vahid.grumpy = GrumpyLevel.Ворчун;
                Vahid.swearword = vahid_words;
                Vahid.bruises = 0;


                Grandpa Abdulbori = new Grandpa();
                Abdulbori.name = "Абдулборий";
                Abdulbori.grumpy = GrumpyLevel.Поехавший;
                Abdulbori.swearword = abdulbori_words;
                Abdulbori.bruises = 0;


                Grandpa Serdzhua = new Grandpa();
                Serdzhua.name = "Серджуа";
                Serdzhua.grumpy = GrumpyLevel.Мужик;
                Serdzhua.swearword = serdzhua_words;
                Serdzhua.bruises = 0;


                Grandpa Sherhan = new Grandpa();
                Sherhan.name = "Шерхан";
                Sherhan.grumpy = GrumpyLevel.Мужик;
                Sherhan.swearword = sherhan_words;
                Sherhan.bruises = 0;


                string[] all_swearwords = {"Дурной п#№ды ребенок", "Я твой роутер е№@*", "Инвалид еба№#%ый", "Сын шайки фашистов", "Ошпарил х№#", "Ва#$%@льный дебошир",
                "Таких бл#@! убивал в своё время", "Под шконку н$@#й", "Я вам кадыки сломаю", "Вы б№@ знаете какие я темки мутил в молодости",};

                Console.WriteLine($"Дед {Anzor.name} получил {Anzor.GrandmaPunches(all_swearwords)} фингалов.\n" +
                    $"Дед {Vahid.name} получил {Vahid.GrandmaPunches(all_swearwords)} фингалов.\n" +
                    $"Дед {Abdulbori.name} получил {Abdulbori.GrandmaPunches(all_swearwords)} фингалов.\n" +
                    $"Дед {Serdzhua.name} получил {Serdzhua.GrandmaPunches(all_swearwords)} фингалов.\n" +
                    $"Дед {Sherhan.name} получил {Sherhan.GrandmaPunches(all_swearwords)} фингалов.\n");


                Console.ReadKey();
            }
        }
    }
}
