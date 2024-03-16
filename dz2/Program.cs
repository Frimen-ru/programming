// Задача 1.Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите число: ");
//         int number = Convert.ToInt32(Console.ReadLine());

//         string result = (number % 7 == 0 && number % 23 == 0) ? "кратно" : "не кратно";
//         Console.WriteLine($"Число {number} {result} одновременно 7 и 23");
//     }
// }
// Задача 2  Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка
// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите координату X: ");
//         int x = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Введите координату Y: ");
//         int y = Convert.ToInt32(Console.ReadLine());

//         int quarter = (x > 0 && y > 0) ? 1 : (x < 0 && y > 0) ? 2 : (x < 0 && y < 0) ? 3 : 4;

//         Console.WriteLine($"Точка с координатами ({x},{y}) находится в {quarter} четверти.");
//     }
// }
// Задача 3 Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа
// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите целое число от 10 до 99: ");
//         int number = Convert.ToInt32(Console.ReadLine());

//         int firstDigit = number / 10;
//         int secondDigit = number % 10;

//         int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;

//         Console.WriteLine($"Наибольшая цифра числа {number} - {maxDigit}");
//     }
// }
// Задача 4 Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую
// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите натуральное число N: ");
//         int number = Convert.ToInt32(Console.ReadLine());

//         foreach (char digit in number.ToString())
//         {
//             Console.Write(digit + ", ");
//         }
//     }
// }