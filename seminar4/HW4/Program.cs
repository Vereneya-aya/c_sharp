// Задача 1: Напишите программу, которая бесконечно 
// запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ 
// или при вводе числа, сумма цифр которого чётная.

// while (true) // true == true
// {
// Console.Write("Введите текст: ");
// string text = Console.ReadLine();
// if (text == "q")
// {
// break;
// }
// if (int.TryParse(text, out int number)) // true, строка состоит только из цифр
// {
// int sum = 0;
// int lastDigit = 0;
// while (number > 0)
//  {
//    lastDigit = number % 10;
//    number = number /10;
//    sum = sum + lastDigit;
//  }
// if (sum % 2 == 0)
// {
// break;
// }
// }
// }

// Задача 2: Задайте массив заполненный случайными 
// трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.


// int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }
// int[] array = CreateArray(4);
// Console.WriteLine($"array: [{string.Join(",", array)}]");

// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] % 2 == 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine($"number of even numbers: {count}");


// Задача 3: Напишите программу, которая перевернёт 
// одномерный массив (первый элемент станет последним, 
// второй – предпоследним и т.д.)


