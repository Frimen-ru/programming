//  Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы
// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите значение M: ");
//         int m = int.Parse(Console.ReadLine());
        
//         Console.Write("Введите значение N: ");
//         int n = int.Parse(Console.ReadLine());
        
//         PrintNumbers(m, n);
//     }

//     static void PrintNumbers(int m, int n)
//     {
//         if (m <= n)
//         {
//             Console.WriteLine(m);
//             PrintNumbers(++m, n); // Увеличиваем m на 1 и передаем его в рекурсивный вызов
//         }
//     }
// }
// 2.Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n
// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите число m: ");
//         int m = int.Parse(Console.ReadLine());
        
//         Console.Write("Введите число n: ");
//         int n = int.Parse(Console.ReadLine());
        
//         Console.WriteLine($"Результат функции Аккермана для m={m} и n={n}: {AckermanFunction(m, n)}");
//     }

//     static int AckermanFunction(int m, int n)
//     {
//         if (m == 0)
//             return n + 1;
//         if (m > 0 && n == 0)
//             return AckermanFunction(m - 1, 1);
        
//         return AckermanFunction(m - 1, n) + AckermanFunction(m, n - 1);
//     }
// }
// 3.Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
using System;

// class Program
// {
//     static void Main()
//     {
//         int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//         PrintArrayReversed(array, array.Length - 1);
//     }

//     static void PrintArrayReversed(int[] array, int index)
//     {
//         if (index >= 0)
//         {
//             Console.WriteLine(array[index]);
//             PrintArrayReversed(array, index - 1);
//         }
//     }
// }
