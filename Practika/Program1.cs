﻿using System;

namespace Practica
{
    class Program
    {
        
        static void ChangesValue(int num1, int num2, int[] randomNumbers)
        {
            int Index1 = Array.IndexOf(randomNumbers, num1);
            int Index2 = Array.IndexOf(randomNumbers, num2);

            randomNumbers[Index1] = num2;
            randomNumbers[Index2] = num1;
        }
        static int Calculations(ref int proizv, out double averageValue, params int[] randomValues)
        {
            int summ = 0;
            
            foreach (int number in randomValues)
            {
                summ += number;
                proizv *= number;
            }

            averageValue = (double) summ / randomValues.Length;

            return summ;
        }
        static void Main(string[] args)
        {
                        
                        
        // Упражнение 1.
        Console.WriteLine("Упражнение 1.\n");

        int[] randomNumbers = new int[20];
        int num1, num2;
        bool res1, res2;
        Random randomNumber = new Random();

        Console.Write("Получим массив: ");

        for (int i = 0; i < randomNumbers.Length; i++)
        {
            int number = randomNumber.Next(100);
            Console.Write(number + " ");
            randomNumbers[i] = number;
        }

        
        Console.Write("\nВведите любое число из массива: ");
        res1 = int.TryParse(Console.ReadLine(), out num1);
        Console.Write("Введите еще одно любое число из массива: ");
        res2 = int.TryParse(Console.ReadLine(), out num2);

        if (res1 && res2 && (Array.IndexOf(randomNumbers, num1) != -1) && (Array.IndexOf(randomNumbers, num2) != -1))
        {
            ChangesValue(num1, num2, randomNumbers);

            Console.Write("\nМассив изменился на: ");

            foreach (int number in randomNumbers)
            {
                Console.Write(number + " ");
            }
        }
        else
        {
        Console.WriteLine("\nНЕправильный ввод, введено не число или оно не является целым, или его нет в массиве");
        }
        
        
        // Упражнение 2.
        Console.WriteLine("\nУпражнение 2.\n");

        Random randomValue = new Random();
        int[] randomValues = new int[10];
        int summ;
        double averageValue;
        int proizv = 1;

        Console.Write("Получили массив: ");

        for (int i = 0; i < randomValues.Length; i++)
        {
            int number = randomValue.Next(50);
            Console.Write(number + " ");
            randomValues[i] = number;
        }

        summ = Calculations(ref proizv, out averageValue, randomValues);

        Console.WriteLine($"\nСумма чисел массива равна {summ}\nПроизведение - {proizv}\nСреднее арифметическое - {averageValue:F}");
            
        }
    }
}            

