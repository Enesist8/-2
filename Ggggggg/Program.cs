namespace Prac_2
{
    internal class Program
    {
        static void Main(string[] args) 
            
        {
            
            Console.WriteLine("Выберите программу:");
            Console.WriteLine("1.Игра Угадай число ");
            Console.WriteLine("2.Таблица умножения ");
            Console.WriteLine("3.Вывод делителей числа");
            Console.WriteLine("4.Выход");
            int program = Convert.ToInt32(Console.ReadLine());
            while (program != 4)
            {
                if (program == 1)
                {
                    Console.WriteLine("Вводите числа, пока не угадаете загаданное число.");
                    int user_num = Convert.ToInt32(Console.ReadLine());
                    Gadalka(user_num);
                }
                else if (program == 2)
                {
                    tablica();
                }
                else if (program == 3)
                {
                    Console.WriteLine("Введите число");
                    int user_value = Convert.ToInt32(Console.ReadLine());
                    delitel(user_value);
                }
                Console.WriteLine(" ");
                Console.WriteLine("Выберите программу:");
                Console.WriteLine("1.Игра Угадай число ");
                Console.WriteLine("2.Таблица умножения ");
                Console.WriteLine("3.Вывод делителей числа");
                Console.WriteLine("4.Выход");
                program = Convert.ToInt32(Console.ReadLine());
            }


        }
        static void Gadalka
            (int num)
        {

            Random rnd = new Random();
            int random_number = rnd.Next(0, 100);
            
            while (random_number != num)
            {
                
                {
                    if (num < random_number)
                    {
                        Console.WriteLine("Больше");
                    }
                    else if (num > random_number)
                    {
                        Console.WriteLine("Меньше");
                    }
                    num = Convert.ToInt32(Console.ReadLine());
                }
                num = num;

            }
            Console.WriteLine("Вы угадали");
        }
        static void tablica()
        {
            Console.WriteLine("   |   1\t2\t3\t4\t5\t6\t7\t8\t9");
            Console.Write("--------------------------------------------------------------------------");
            Console.WriteLine();
            for (int a = 1; a < 10; a++)
            {
                Console.Write(a + "  |  ");
                for (int j = 1; j < 10; j++)
                {
                    Console.Write("\t" + a * j);
                }
                Console.WriteLine("");
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
        static void delitel(int A)
        {
            int num = 1;
            Console.WriteLine("Введите число" + A );
            while (A >= num)
            {
                if (A % num == 0)
                {
                    Console.Write(num);
                    Console.Write("\t");
                    num++;
                }
                else
                {
                    num++;
                }
            }
        }
    }
}