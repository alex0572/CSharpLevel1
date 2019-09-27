using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Lesson2
{
    class Program
    {
        #region Метод, возвращающий минимальное из трёх чисел.
        static int Min(int a, int b, int c)
        {
            if (a < c && a < b)
            {
                return a;
            }
            else
            {
                if (b < c)
                {
                    return b;
                }
                else
                {
                    return c;
                }
            }
            
        }

        #endregion

        #region Метод подсчета количества цифр числа.

        static int Digits(string number)
        {
            return number.Length;
        }

        #endregion



        static void Main(string[] args)
        {
            /* ДЗ ко 2 уроку - Ляшенко А.В.*/

            #region DZ - 2-1
            //// a) Написать программу, возвращающую минимальное из трёх чисел.

            //Console.Write("Введите первое число: ");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Введите второе число: ");
            //int b = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Введите тертье число: ");
            //int c = Convert.ToInt32(Console.ReadLine());

            //int min;

            //if (a < c && a < b)
            //{
            //    min = a;
            //}
            //else
            //{
            //    if (b < c)
            //    {
            //        min = b;
            //    }
            //    else
            //    {
            //        min = c;
            //    }
            //}

            //Console.WriteLine($"Минимальное из трех чисел = {min}");
            //Console.ReadLine();


            //// b) Написать метод, возвращающий минимальное из трёх чисел.

            //Console.Write("Введите первое число: ");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Введите второе число: ");
            //int b = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Введите тертье число: ");
            //int c = Convert.ToInt32(Console.ReadLine());            

            //Console.WriteLine($"Минимальное из трех чисел = " + Min(a,b,c));
            //Console.ReadLine();


            #endregion

            #region DZ - 2-2

            //// Написать метод подсчета количества цифр числа. 

            //Console.Write("Введите число: ");
            //string number = (Console.ReadLine()); ;

            //Console.WriteLine("Количество цифр: " + Digits(number));
            //Console.ReadKey();

            #endregion

            #region DZ - 2-3
            //Подсчитать сумму всех нечетных положительных чисел.

            //int num = 0;
            //int sum = 0;

            //Console.WriteLine("Вводите целые числа, для завершения введите 0: ");                      

            //do
            //{
            //    num = int.Parse(Console.ReadLine());
            //    if (num > 0 && num % 2 == 1)
            //        sum += num;

            //} while (num != 0);

            //Console.WriteLine("Cумму всех нечетных положительных чисел: " + sum);
            //Console.ReadLine();
            #endregion

            #region DZ - 2-4
            /* Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
               (Логин: root, Password: GeekBrains).
               Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
               С помощью цикла do while ограничить ввод пароля тремя попытками.*/


            //string login = "root";
            //string password = "GeekBrains";

            //int count = 0;
            //do
            //{
            //    Console.ForegroundColor = ConsoleColor.White;
            //    Console.Write("Введите логин: ");
            //    string a = Console.ReadLine();

            //    Console.Write("Введите пароль: ");
            //    string b = Console.ReadLine();


            //    if (login == a && password == b)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.WriteLine("Добро пожаловать!!! ДОСТУП ОТКРЫТ!!!");
            //        Console.ReadLine();                    
            //        break;
            //    }
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Вы неверно ввели логин или пароль. ДОСТУП ЗАПРЕЩЕН!!!");                
            //    ++count;
            //} while (count < 3);            

            #endregion

            #region DZ - 2-5

            /* 	Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает,
                нужно ли человеку похудеть, набрать вес или всё в норме.*/

            Console.Write("Введите вес(кг): ");
            Double m = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите рост(м): ");
            Double h = Convert.ToDouble(Console.ReadLine());

            Double I = m / (h * h);

            if (I >= 18.5 && I <= 25)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Индекс массы тела (ИМТ) равен: {I:0.00} ! Нормальная масса тела!");
            }
            else if (I < 18.5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Индекс массы тела (ИМТ) равен: {I:0.00} ! Наблюдается дефицит массы!");
                double r = (18.5 - I) * h * h;                
                Console.WriteLine($"Необходимо набрать {r:0.00} кг для нормализации веса!");
            }
            else if (I > 25)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Индекс массы тела (ИМТ) равен: {I:0.00} ! Избыточная масса тела!");
                double r = (I - 24.99) * h * h;                
                Console.WriteLine($"Необходимо сбросить {r:0.00} кг для нормализации веса!");
            }
                                   
            Console.ReadLine();

            #endregion

        }
    }
}
