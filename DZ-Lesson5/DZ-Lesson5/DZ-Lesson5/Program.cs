using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

                                                            /* ДЗ к 5 уроку - Ляшенко А.В.*/

namespace DZ_Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DZ - 5-1
            /* Создать программу, которая будет проверять корректность ввода логина.
               Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, 
               при этом цифра не может быть первой: а) без использования регулярных выражений;*/

            Console.WriteLine("Введите логин");
            string login = Console.ReadLine();
            

            bool flag = true;
            for (int i = 0; i < login.Length; i++)
            {  
                if (login.Length < 2 || login.Length > 10)
                {
                    flag = false;
                    Console.WriteLine("Неверная длина логина (не менее 2 и не более 10 символов !!!)");
                    Console.ReadKey();
                    break;
                }
                if (Char.IsDigit(login[0]))
                {
                    flag = false;
                    Console.WriteLine("Неверный формат ввода (цифра не может быть первой !!!)");
                    Console.ReadKey();
                    break;
                }
                if (!(Char.IsDigit(login[i]) || login[i] >= 'a' && login[i] <= 'z' || login[i] >= 'A' && login[i] <= 'Z'))
                {
                    flag = false;
                    Console.WriteLine("Введены недопустимые символы (только буквы латинского алфавита или цифры !!!)");
                    Console.ReadKey();
                    break;
                }
            }
            if (flag)
                Console.WriteLine("Введенный логин корректен !!!");
                       
            Console.ReadKey();
            #endregion
                       
        }
    }
}
