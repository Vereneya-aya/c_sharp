// Задача 1: Задайте двумерный массив символов 
// (тип char [,]). Создать строку из символов этого массива.


// string GetStringFromCharArray (char[,] array)
// {
//     string result = string.Empty; 
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             result += array[i,j];
//         }
//     }
//     return result;
// }
// void PrintMatrix(char[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++) // стр
//     {
//         for (int j = 0; j < matr.GetLength(1); j++) // столбцы
//         {
//             Console.Write($"{matr[i, j]}\t"); // "\t" = 4 пробела 
//         } // Закончили обход 0 строки, идем в 1
//         Console.WriteLine(); // Перенос на новую строчку
//     }
// }

// char[,] charMatrix = {{'a', 'b', 'c'},{'d', 'e', 'f'}};
// Console.WriteLine("Массив: ");
// PrintMatrix(charMatrix);
// string res = GetStringFromCharArray(charMatrix);
// Console.WriteLine($"Результат: {res}");

// Задача 2: Задайте строку, содержащую латинские буквы 
// в обоих регистрах. Сформируйте строку, в которой все 
// заглавные буквы заменены на строчные.

// string ChangeRegister (string str)
// {
//     for (int i = 0; i < str.Length; i++)
//     {
//         if (char.IsUpper(str[i]) == true)
//         {
//             str[i] = Char.ToLower(str[i]);
//         }
//         else
//         {
//             str[i] = Char.ToUpper(str[i]);
//         }
//     }
//     return str;
// }

// Console.Write("Введите строчку: ");
// string inputString = Console.ReadLine();
// string result = inputString.ToLower();
// Console.WriteLine(result);


// Задача 3: Задайте произвольную строку. 
// Выясните, является ли она палиндромом.

bool IsPalindrom(string str)
{
    int res = 0;
    for (int i = 0; i < str.Length / 2; i++)
    {
        for (int j = str.Length - 1; j > str.Length; j--)
        {
            if (str[i] == str[j])
            {
               res = 1;
            }
            else
            {
                res = 0;
            }
        }
    }
    if (res = 1)
    {
        return true;
        }

    else
    {
        return false;
    }
     
}

Console.Write("Введите строчку: ");
string str = Console.ReadLine();
if (IsPalindrom(str) == true)
{
    Console.WriteLine("палиндром");
}
else
{
    Console.WriteLine("не палиндром");
}

// Задача 4*(не обязательная): Задайте строку, 
// состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены 
// в обратном порядке. В полученной строке слова должны быть 
// также разделены пробелами.

// string input = "Hello my world";
// // Вызов метода для обращения порядка слов в строке 
// string result = ReverseWords(input);
// // Вывод результата
// Console.WriteLine(result); 
// // Метод для обращения порядка слов в строке 
//  string ReverseWords(string str)
// // Разделение строки на слова 
// string[] words = str.Split(' ');
// // Обращение порядка слов 
// Array.Reverse(words);
// // Соединение слов обратно в строку с пробелами
// return string.Join(" ", words);