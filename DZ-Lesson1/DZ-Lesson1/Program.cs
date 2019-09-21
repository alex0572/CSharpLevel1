using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Lesson1
{
    class Program
    {
        #region Метод подсчитывает расстояние между точками

        static double R(double x1, double x2, double y1, double y2)
        {
            return (Double)Math.Sqrt((Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2)));
        }
        #endregion

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

            //Console.Write("Введите вес(кг): ");
            //Double m = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Введите рост(м): ");
            //Double h = Convert.ToDouble(Console.ReadLine());

            //Double I = m / (h * h);


            //Console.WriteLine($"Индекс массы тела (ИМТ) равен: {I:f2} !"); //используя вывод со знаком $ и спецификатор формата .f2

            //Console.ReadLine();

            #endregion

            #region ДЗ 1-3a Подсчитывает расстояние между точками (Вариант без метода ) 

            /* 	Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
                по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).
                Вывести результат, используя спецификатор формата .f2 (с двумя знаками после запятой); Ляшенко А.В.*/

            //Console.WriteLine("Введите x1");
            //Double x1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите x1");
            //Double x2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите y1");
            //Double y1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите y2");
            //Double y2 = Convert.ToDouble(Console.ReadLine());

            //Double r = (Double)Math.Sqrt((Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2)));

            //Console.WriteLine($"Расстояние между точками равно: {r:f2} !"); //используя вывод со знаком $ и спецификатор формата .f2

            //Console.ReadLine();

            #endregion

            #region ДЗ 1-3b* Подсчитывает расстояние между точками (Вариант c методом) 

            /* 	Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
                по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).                
                Выполнить задание, оформив вычисления расстояния между точками в виде метода.  Ляшенко А.В.*/

            Console.WriteLine("Введите x1");
            Double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x1");
            Double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y1");
            Double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y2");
            Double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Расстояние между точками равно: " +  R(x1, x2, y1, y2) + "!");
            Console.ReadLine();

            #endregion
        }
    }
}
