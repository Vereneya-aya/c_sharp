﻿Sem 4

// // TASK1
// // тип_метода ИмяМетода (пар1, пар2, ... парN)
// // a, b - 2 числа, sign - знак арифм. операции
// int Calculate (int a, int b, string sign)
// {
//     if (sign == "+")
//     {
//         return a + b; // Cумма чисел
//     }
//     else if (sign == "-")
//     {
//         return a - b; // Разность чисел
//     }
//     else if (sign == "*")
//     {
//         return a * b; // Произ-е чисел
//     }
//     else
//     {
//         Console.WriteLine("Введен неизвестный знак арифм. операции");
//         return 0;
//     }
// }

// // Вызов метода 
// Console.WriteLine(Calculate(2, 3, "+")); // 5
// Console.WriteLine(Calculate(2, 3, "-")); // -1
// Console.WriteLine(Calculate(20, 3, "*")); // 60
// Console.WriteLine(Calculate(20, 3, ".")); // 60

// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2

// // тип_метода ИмяМетода (пар1, пар2, ... парN)
// // a, b - 2 числа, sign - знак арифм. операции
// int Calculate(int a, int b, string sign)
// {
//     if (sign == "+")
//     {
//         return a + b; // Cумма чисел
//     }
//     else if (sign == "-")
//     {
//         return a - b; // Разность чисел
//     }
//     else if (sign == "*")
//     {
//         return a * b; // Произ-е чисел
//     }
//     else
//     {
//         Console.WriteLine("Введен неизвестный знак арифм. операции");
//         return 0;
//     }
// }

// // Вызов метода 
// Console.WriteLine(Calculate(2, 2, "+")); // 5
// Console.WriteLine(Calculate(2, 2, "-")); // 0
// Console.WriteLine(Calculate(20, 3, "*")); // 60
// Console.WriteLine(Calculate(20, 3, ".")); // 60


// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2

// TASK2

// int[] CreateArray(int size)
// {
//     int[] array = new int[size]; // Массив на size элементов
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 101);
//         // [1, 101) или [1,100]
//     }
//     return array;
// }
// int GetCount(int[] arr)
// {
//     int count = 0; 
//     for (int i = 0; i < arr.Length; i++)
//     {
//         // "&&" - "И": апельсины И яблоки
//         if (arr[i] % 7 == 0 && arr[i] % 10 == 1)
//         {
//             count++; // count = count + 1
//             // Число нашли
//         }
//     }
//     return count;
// }


// // Вызов метода
// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] res = CreateArray(N); // Создали массив на N элементов
// Console.WriteLine($"Массив: [ {string.Join("; ", res)} ]");
// Console.WriteLine($"Результат: {GetCount(res)}");


// TASK3
// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.

// [2, 3, 1] => 231

// int[] CreateArray(int size)
// {
//     int[] array = new int[size]; // Массив на size элементов
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(10); // [0, 9]
//     }
//     return array;
// }

// int ConvertArrayToInteger(int[] array)
// {
//     int result = 0;
//     for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
//     {
//         result = result + array[i] * (int)Math.Pow(10, j);
//         // 10 - число, j - степень
//     }
//     return result;
// }

// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] res = CreateArray(N); // Создали массив на N элементов
// Console.WriteLine($"Массив: [ {string.Join("; ", res)} ]");
// Console.WriteLine($"Результат: {ConvertArrayToInteger(res)}");


