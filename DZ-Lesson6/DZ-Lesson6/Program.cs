using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/* ДЗ к 6 уроку - Ляшенко А.В.*/

namespace DZ_Lesson6
{
    #region Описание делегата к DZ - 6-1

    //public delegate double Func(double a, double x);

    #endregion

    #region Описание делегата к DZ - 6-2

    public delegate double Func(double x);

    #endregion

    class Program
    {
        #region Методы к DZ - 6-1

        //// Создаем метод, который принимает делегат
        //public static void Table(Func F, double a, double x, double b)
        //{
        //    Console.WriteLine("----- A ------- X -------- Y -----");
        //    while (x <= b)
        //    {
        //        Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000} |", a, x, F(a, x));
        //        x += 1;
        //    }
        //    Console.WriteLine("-----------------------------------");
        //}
        //// Создаем методы для передачи их в качестве параметра в Table
        //public static double MyFunc(double a, double x)
        //{
        //    return a * x * x;
        //}
        //public static double MySin(double a, double x)
        //{
        //    return a * Math.Sin(x);
        //}

        #endregion

        #region Методы и функции к DZ - 6-2

        public static double Func1(double x)
        {
            return x * x - 50 * x + 10;
        }

        public static double Func2(double x)
        {
            return x * x -154;
        }
        public static double Func3(double x)
        {
            return x + 25 * x / 6;
        }
        public static void SaveFunc(string fileName, double a, double b, double h, Func F)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }

        #endregion

        static void Main(string[] args)
        {
            #region DZ - 6-1

            ///*Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). 
            // Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x)*/

            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("Таблица функции a*x^2:\n");
            //Console.ForegroundColor = ConsoleColor.White;
            //Table(new Func(MyFunc), -4.7, -2, 5);

            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("Таблица функции a*sin(x):\n");
            //Console.ForegroundColor = ConsoleColor.White;
            //Table(new Func(MySin), 7, -5.3, 2); 

            //Console.ReadKey();

            #endregion

            #region DZ - 6-2

            /* Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата. 
               а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум. 
               Использовать массив (или список) делегатов, в котором хранятся различные функции.*/

            int x;
            Console.WriteLine("Введите число:");

            Func[] F = { Func1, Func2, Func3 };
            Console.WriteLine("Сделайте выбор:\n\n 1 - функция №1 \n 2 - функция №2 \n 3 - функция №3");            
            int index = int.Parse(Console.ReadLine());
            SaveFunc("data.bin", -100, 10, 0.9, F[index - 1]);
            Console.WriteLine(Load("data.bin"));
            Console.ReadKey();

            #endregion
        }
    }
}
