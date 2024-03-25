//Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
// using System;

// class Program
// {
//     static void Main()
//     {
//         while (true)
//         {
//             Console.WriteLine("Введите целое число или 'q' для выхода:");
//             string input = Console.ReadLine();

//             if (input.ToLower() == "q")
//             {
//                 Console.WriteLine("Программа завершена.");
//                 break;
//             }

//             int number;
//             if (int.TryParse(input, out number))
//             {
//                 if (IsSumOfDigitsEven(number))
//                 {
//                     Console.WriteLine("Сумма цифр числа чётная. Программа завершена.");
//                     break;
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Неверный формат ввода. Попробуйте снова.");
//             }
//         }
//     }

//     static bool IsSumOfDigitsEven(int number)
//     {
//         int sum = 0;
//         while (number != 0)
//         {
//             sum += number % 10;
//             number /= 10;
//         }

//         return sum % 2 == 0;
//     }
// }
// Задача 2. Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// using System;

// class Program
// {
//     static void Main()
//     {
//         Random random = new Random();
//         int[] numbers = new int[10]; // Создаем массив из 10 элементов

//         // Заполняем массив случайными трехзначными числами
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = random.Next(100, 1000);
//         }

//         Console.WriteLine("Сгенерированный массив:");
//         foreach (int number in numbers)
//         {
//             Console.Write(number + " ");
//         }
//         Console.WriteLine();

//         int countEvenNumbers = 0;

//         foreach (int number in numbers)
//         {
//             if (number % 2 == 0) // Проверяем, является ли число четным
//             {
//                 countEvenNumbers++; // Увеличиваем счетчик четных чисел
//             }
//         }

//         Console.WriteLine("Количество четных чисел в массиве: " + countEvenNumbers);
//     }
// }
// Задача 3 Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)
// using System;

// class Program
// {
//     static void Main()
//     {
//         int[] array = { 1, 3, 5, 6, 7, 8 }; // Одномерный массив
        
//         Console.WriteLine("Исходный массив:");
//         PrintArray(array);

//         ReverseArray(array); // Переворачиваем массив

//         Console.WriteLine("\nПеревернутый массив:");
//         PrintArray(array);
//     }

//     static void ReverseArray(int[] array)
//     {
//         int length = array.Length;
//         for (int i = 0; i < length / 2; i++)
//         {
//             int temp = array[i];
//             array[i] = array[length - i - 1];
//             array[length - i - 1] = temp;
//         }
//     }

//     static void PrintArray(int[] array)
//     {
//         foreach (int num in array)
//         {
//             Console.Write(num + " ");
//         }
//     }
// }
