﻿using System;

namespace Tumakov5
{
    class Program
    {
        static double MaxNumber(double num1, double num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
        static void ChangeValue(ref string Value1, ref string Value2)
        {
            string Value3 = Value1;
            Value1 = Value2;
            Value2 = Value3;
        }
        static bool FactorialCycle(out int factorial, int eNumber)
        {
            try
            {
                factorial = 1;

                for (int i = 1; i <= eNumber; i++)
                {
                    checked
                    {
                        factorial *= i;
                    }
                }
                return true;
            }
            catch (OverflowException)
            {
                factorial = -1;
                return false;
            }
        }
        static int FactorialRecursion(int eNumber)
        {
            if (eNumber == 1)
            {
                return 1;
            }
            return eNumber * FactorialRecursion(eNumber - 1);
        }
        static int EuclidAlgorithm(int num11, int num22)
        {
            int remainder, result;
            do
            {
                remainder = num11 % num22;
                num11 = num22;
                result = num22;
                num22 = remainder;
            } while (remainder != 0);

            return result;
        }
        static int EuclidAlgorithm(int num1, int num2, int num3)
        {
            int divider = EuclidAlgorithm(num1, num2);
            int result = EuclidAlgorithm(divider, num3);

            return result;
        }
        static int FibonacciNumbers(int numVal)
        {
            if (numVal == 1 || numVal == 2)
            {
                return 1;
            }

            return FibonacciNumbers(numVal - 1) + FibonacciNumbers(numVal - 2);
        }
        static void Main(string[] args)
        {

            // Упражнение 5.1.
            Console.WriteLine("УПРАЖНЕНИЕ 5.1. Выведение максимального числа из 2 введенных\n");

            double num1, num2, maxnum;
            bool res1, res2;

            Console.Write("Введите первое число: ");
            res1 = double.TryParse(Console.ReadLine(), out num1);
            Console.Write("Введите второе число: ");
            res2 = double.TryParse(Console.ReadLine(), out num2);

            if (res1 && res2)
            {
            maxnum = MaxNumber(num1, num2);

            Console.WriteLine($"\nМаксимальное число({num1}; {num2}) = {maxnum}");
            }
            else
            {
            Console.WriteLine("\nНеправильный ввод числа\n");
            }

            
            // Упражнение 5.2.
            Console.WriteLine("\nУПРАЖНЕНИЕ 5.2. Следующие 2 введенных значения поменяются местами\n");

            string Value1, Value2;

            Console.Write("Введите первое значение: ");
            Value1 = Console.ReadLine();
            Console.Write("Введите второе значение: ");
            Value2 = Console.ReadLine();

            ChangeValue(ref Value1, ref Value2);

            Console.WriteLine($"\nЗначения поменялись местами. Первое значение - {Value1}, второе значение - {Value2}");

            // Упражнение 5.3. 
    
            Console.WriteLine("\nУПРАЖНЕНИЕ 5.3.\n");

            int factorial, eNumber;
            bool fResult = true;
            bool pResult;

            Console.Write("Введите натуральное число для нахождения фактириала данного числа: ");
            pResult = int.TryParse(Console.ReadLine(), out eNumber);

            if (pResult && eNumber > 0)
            {
            fResult = FactorialCycle(out factorial, eNumber);

                if (fResult)
                {
                    Console.WriteLine($"\n{eNumber}! = {factorial}");
                }
                else
                {
                    Console.WriteLine($"\nНеправильный ввод, введенное число слишком большое.\n");
                }
            }
            else
            {
            Console.WriteLine("\nВы ввели не число или оно не является натуральным\n");
            }


            //Упражнение 5.4.
            Console.WriteLine("\nУПРАЖНЕНИЕ 5.4.\n");

            
            Console.Write("Введите натуральное число, для нахождения факториала этого числа путем рекурсии: ");
            pResult = int.TryParse(Console.ReadLine(), out eNumber);

            if (pResult && eNumber > 0)
            {
                factorial = FactorialRecursion(eNumber);

                if (factorial == 0)
                {
                    Console.WriteLine($"\nНеправильный ввод, введенное число слишком большое.\n");
                }
                else
                {
                    Console.WriteLine($"\n{eNumber}! = {factorial}\n");
                } 
            }  
            else
            {
                Console.WriteLine("\nВы ввели не число или оно не является натуральным\n");
            }
        

            // Упражнение 5.1.
            Console.WriteLine("Упражнение 5.1.(1)  Определение НОД 2 и 3 чисел\n");

            int num11, num22, num3, nod;
            bool res3;

                Console.Write("Введите первое натуральное число: ");
                res1 = int.TryParse(Console.ReadLine(), out num11);
                Console.Write("Введите второе натуральное число: ");
                res2 = int.TryParse(Console.ReadLine(), out num22);

                if ((res1 && res2) && (num11 > 0 && num22 > 0))
                {
                    nod = EuclidAlgorithm(num11, num22);

                    Console.WriteLine($"\nНОД({num11}, {num22}) = {nod}\n");           
                }
                else
                {
                    Console.WriteLine("Вы ввели не число или оно не является натуральным\n");
                }

                Console.Write("Введите первое натуральное число: ");
                res1 = int.TryParse(Console.ReadLine(), out num11);
                Console.Write("Введите второе натуральное число: ");
                res2 = int.TryParse(Console.ReadLine(), out num22);
                Console.Write("Введите третье натуральное число: ");
                res3 = int.TryParse(Console.ReadLine(), out num3);

                if ((res1 && res2 && res3) && (num11 > 0 && num22 > 0 && num3 > 0))
                {
                    nod = EuclidAlgorithm(num11, num22, num3);

                    Console.WriteLine($"\nНОД({num11}, {num22}, {num3}) = {nod}");
                }
                else
                {
                    Console.WriteLine("Вы ввели не число или оно не является натуральным\n");
                }


            // Упражнение 5.2.(1) 
            Console.WriteLine("Упражнение 5.2.\nВведите порядковый номер числа ряда Фибоначчи: ");
            if (int.TryParse(Console.ReadLine(), out int NumVal))
            {
                Console.WriteLine($"Номеру {NumVal} соотвествует число {FibonacciNumbers(NumVal)} из ряда Фибоначчи(не считая первое число 0)");
            }
            else
            {
                Console.WriteLine("Неправильный ввод числа\n");
            }          
        }
    }
}

  

                        