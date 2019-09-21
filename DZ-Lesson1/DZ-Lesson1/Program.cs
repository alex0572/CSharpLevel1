using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ДЗ 1-1 Анкета 

            /* 	Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
                  а) используя  склеивание;
                  б) используя форматированный вывод;
                  в) используя вывод со знаком $. Ляшенко А.В. */


            //Console.Write("Введите имя: ");
            //string name = Console.ReadLine();

            //Console.Write("Введите фамилию: ");
            //string famil = Console.ReadLine();

            //Console.Write("Введите возраст: ");
            //string age = Console.ReadLine();

            //Console.Write("Введите рост: ");
            //string gain = Console.ReadLine();

            //Console.Write("Введите вес: ");
            //string weight = Console.ReadLine();

            //Console.WriteLine("Вас зовут: " + name + " " + famil + ", возраст: " + age + ", рост: " + gain + ", вес: " + weight + "!"); //используя склеивание
            //Console.WriteLine("Вас зовут: {0} {1}, возраст: {2}, рост: {3}, вес: {4}!", name, famil, age, gain, weight); //используя форматированный вывод
            //Console.WriteLine($"Вас зовут: {name} {famil}, возраст: {age}, рост: {gain}, вес: {weight}!"); //используя вывод со знаком $

            //Console.ReadLine();

            #endregion

            #region ДЗ 1-2 Индекс массы тела (ИМТ)  

            /* 	Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) 
                по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах. Ляшенко А.В.*/

            Console.Write("Введите вес(кг): ");
            Double m = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите рост(м): ");
            Double h = Convert.ToDouble(Console.ReadLine());

            Double I = m / (h * h);


            Console.WriteLine($"Индекс массы тела (ИМТ) равен: {I:f2} !"); //используя вывод со знаком $ и спецификатор формата .f2

            Console.ReadLine();

            #endregion
        }
    }
}
