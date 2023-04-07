﻿using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Numerics;

namespace MyApp // Note: actual namespace depends on the project name.
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //SearchNumber();
            //RemoveElement();
            //MaxMinAvr();
            AvrArray();
        }

        public static void SearchNumber()
        {
            int[] numbers = { 0, 2, 4, 6, 8, 10 };

            Console.Write("Введите число: ");

            int target = int.Parse(Console.ReadLine());

            bool isExist = numbers.Contains(target);
            if (isExist)
            {
                Console.WriteLine("The number is found");
            }
            else
            {
                Console.WriteLine("The number is not found");

            }
        }

        public static void RemoveElement()
        {
            int[] numbers = { 0, 2, 4, 2, 8, 10, 3, 4, 5 };
            List<int> result = new List<int>(); //Создаем лист, в который будет записываться значения после проверки элемента

            Console.Write("Введите число: ");
            int target = int.Parse(Console.ReadLine());
            bool isExist = numbers.Contains(target);

            if (!isExist)
            {
                Console.WriteLine("Not found");
                return;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (target != numbers[i])
                {
                    result.Add(numbers[i]);
                }
            }
            foreach (var num in result)
            {
                Console.Write("{0} ", num);
            }

        }

        public static void MaxMinAvr()
        {

            Random random = new Random();
            int[] numbers = new int[6];

            Console.WriteLine("Intialaize Array");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 10);
                Console.Write(numbers[i] + " ");
            }

            int max = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            int min = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            double sum = 0;
            double avr = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            avr = Math.Round((sum / numbers.Length), 2);

            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Average " + avr);
        }

        public static void AvrArray()
        {
            int[] array1 = { 0, 2, 4, 6, 8 };
            int[] array2 = { 1, 3, 5, 7, 9 };

            Console.Write("The first array: ");
            for (int i = 0; i < array1.Length; i++)
                Console.Write(array1[i] + " ");
            Console.WriteLine();
            Console.Write("The second array: ");
            for (int i = 0; i < array2.Length; i++)
                Console.Write(array2[i] + " ");

            double sum1 = 0;
            double avr1 = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                sum1 += array1[i];
            }
            avr1 = Math.Round((sum1 / array1.Length), 2);

            Console.WriteLine();
            Console.WriteLine("Average first: " + avr1);

            double sum2 = 0;
            double avr2 = 0;
            for (int i = 0; i < array2.Length; i++)
            {
                sum2 += array2[i];
            }
            avr2 = Math.Round((sum2 / array2.Length), 2);

            Console.WriteLine("Average second: " + avr2);

            if (avr2 > avr1)
            {
                Console.WriteLine("The average of the second array is greater");
            }
            else if (avr2 < avr1)
            {
                Console.WriteLine("The average of the first array is greater");
            }
            else
            {
                Console.WriteLine("The averages are equal.");
            }
        }
    }
}