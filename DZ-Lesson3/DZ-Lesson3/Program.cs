using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Lesson3
{
    class Program
    {
        #region 3-2

        static int MyTryParse()
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x))
                    Console.Write("ОШИБКА!!!\nПожалуйста, повторите ввод: ");
                else return x;
        }

        #endregion


        static void Main(string[] args)
        {
            /* ДЗ ко 3 уроку - Ляшенко А.В.*/

            #region DZ - 3-1
            /*а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
              б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
              в) Добавить диалог с использованием switch демонстрирующий работу класса.*/


            //Complex complex1;
            //Console.Write("Введите действительную часть числа  1: ");
            //complex1.re = int.Parse(Console.ReadLine());
            //Console.Write("Введите мнимую часть числа 1: ");
            //complex1.im = int.Parse(Console.ReadLine());

            //Complex complex2;
            //Console.Write("Введите действительную часть числа  2: ");
            //complex2.re = int.Parse(Console.ReadLine());
            //Console.Write("Введите мнимую часть числа 2: ");
            //complex2.im = int.Parse(Console.ReadLine());


            //int m;
            //Console.Write("Введите номер действия с комплексными числами: \n Для суммы - 1 \n Для вычитания - 2  \n Для произведения - 3 \n Для выхода нажмие 'Enter' \n");
            //m = Convert.ToInt32(Console.ReadLine());

            //switch (m)
            //{
            //    case 1:
            //        //Console.WriteLine("Case 1");
            //        Complex result = complex1.Plus(complex2);
            //        Console.WriteLine(result.ToString());
            //        break;
            //    case 2:
            //        //Console.WriteLine("Case 2");
            //        result = complex1.Minus(complex2);
            //        Console.WriteLine(result.ToString());
            //        break;
            //    case 3:
            //        //Console.WriteLine("Case 3");
            //        result = complex1.Multi(complex2);
            //        Console.WriteLine(result.ToString());
            //        break;
            //    default:
            //        //Console.WriteLine("Default case");
            //        break;
            //}
            //Console.ReadLine();

            #endregion

            #region DZ - 3-2

            /*С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
              Требуется подсчитать сумму всех нечётных положительных чисел. 
              Сами числа и сумму вывести на экран, используя tryParse.*/

            Console.WriteLine("Вводите целые числа, для завершения введите 0: ");
            
            int sum = 0;
            while (true)
            {                
                int num = MyTryParse();
                   
                if (num == 0)
                {
                    break;
                }
                else if (num > 0 && num % 2 == 1)
                {
                    sum++;
                }
            }

            Console.WriteLine("Cумму всех нечетных положительных чисел: " + sum);
            Console.ReadKey();

            #endregion


        }
    }
}
