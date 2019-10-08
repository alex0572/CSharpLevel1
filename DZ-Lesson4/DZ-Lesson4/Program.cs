using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DZ_Lesson4
{
    #region DZ - 4-1 и 4-2

    public class StaticClass
    {
        private int[] a;

        //public StaticClass(int elem, int min, int max) //Заполнение случайными числами 
        //{
        //    a = new int[elem];
        //    Random random = new Random();
        //    for (int i = 0; i < elem; i++)
        //        a[i] = random.Next(min, max);
        //}

        public StaticClass(string filename)  //Считывание массива из текстового файла
        {
            StreamReader sr = new StreamReader("D:\\data.txt");
            //  Считываем количество элементов массива
            int N = int.Parse(sr.ReadLine());
            a = new int[N];
            //  Считываем массив
            for (int i = 0; i < N; i++)
            {
                a[i] = int.Parse(sr.ReadLine());
            }
            sr.Close();
        }

        public int PairArrayElements() //Подсчет пар элементов массива, одно из которых делится на 3
        {
            int count = 0;
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] % 3 == 0 || a[i + 1] % 3 == 0)
                    count++;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Пара чисел: {0,6}   и {1,6}", a[i], a[i + 1]);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("Количество пар: " + count + " !!!");
            return count;
        }

    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            /* ДЗ к 3 уроку - Ляшенко А.В.*/

            #region DZ - 4-1 и 4-2

            /* 1) Дан  целочисленный  массив  из 20 элементов.  Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно. 
              Заполнить случайными числами.  Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3.
              В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.
               
               2) Реализуйте задачу 1 в виде статического класса StaticClass;
                  а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
                  б) *Добавьте статический метод для считывания массива из текстового файла.
                      Метод должен возвращать массив целых чисел;*/


            //Объявление массива из 20 элементов со значениями от -10 000 до 10 000             
            //StaticClass Ar = new StaticClass(21, -10000, 10000);

            //Объявление массива со считыванием из текстового файла
            StaticClass Ar = new StaticClass("data.txt");
            Ar.PairArrayElements();
            Console.ReadLine();

            #endregion
        }
    }
}
