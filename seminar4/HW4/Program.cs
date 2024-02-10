// Задача 1: Напишите программу, которая бесконечно 
// запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ 
// или при вводе числа, сумма цифр которого чётная.

// while (true) // true == true Бесконечный цикл
// {
// Console.Write("Введите текст: ");
// string text = Console.ReadLine();
// if (text == "q")
// {
// break;
// }
// int number;
// if (int.TryParse(text, out number)) // true, строка состоит только из цифр
// {
// int sum = 0;
// while (number > 0)
//  {
     
//    sum += number %10;
//     number /= 10;
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

// int[] array = { 1, 2, 3, 4, 5, 6, 7 };
// int i = 0;
// int j = array.Length - 1;
// int temp = array[i];
// while (i < array.Length / 2)
// {
//     temp = array[i];
//     array[i] = array[j];
//     array[j] = temp;
//     i++;
//     j--;
// }
// Console.WriteLine($"reverse array: [{string.Join(",", array)}]");
