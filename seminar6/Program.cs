// TASK 1
// // Задайте массив символов (тип char []). 
// // Создайте строку из символов этого массива. 

// // [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

// string GetStringFromCharArray (char[] array)
// {
//     // array = [‘a’, ‘b’, ‘c’, ‘d’] 
//     string result = string.Empty; // ""
//     foreach (char symbol in array)
//     // symbol = 'a', symbol = 'b', symbol = 'c', symbol = 'd'
//     {
//         result += symbol; // result = result + symbol
//         // result = "" + "a"; result = "a"
//         // result = "a" +"b"; result = "ab"
//         // result = "ab" + "c"; result = "abc"
//         // result = "abc" + "d"; result = "abcd"
//     }
//     return result;
// }
// // '1' - char, "3rr2" - string
// char[] chars = {'1', 'd', '!', '2', 'f'};
// Console.WriteLine($"Массив: [{string.Join("; ", chars)}]");
// string res = GetStringFromCharArray(chars);
// Console.WriteLine(res);

// // На основе символов строки (тип string) сформировать массив
// // символов (тип char[]). Вывести массив на экран.

// // “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

// char[] ConvertStringToCharArray (string str)
// {
//     char[] chars = new char[str.Length]; 
//     // "hi" => [,], str.Length = 2, массив на 2 элемента
//     for (int i = 0; i < str.Length; i++)
//     {
//         chars[i] = str[i]; 
//         //chars[0] = str[0], chars[0]=h
//         //chars[1] = str[1], chars[1]=i
//         // chars = ['h', 'i']
//     }
//     return chars;
//     // str = "hi" => [h,i]
//     // "hi" => [str[0], str[1]]
// }
// // “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]
// string str = "Hello world";
// Console.WriteLine($"Строчка исходная: {str}");
// char[] chars = ConvertStringToCharArray(str);
// Console.WriteLine($"Массив: [{string.Join("; ", chars)}]");

//TASK 3
// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

// int GetVovelsCount (string str)
// {
//     // str = "hello", 'h' - 1 символ, char
//     string vovels = "aoueyi"; // Гласные буквы в англ. алфавите
//     int vovelsCount = 0; // Количество гласных 
//     foreach (char symbol in str) // Получает каждый символ введенной строчки
//     {
//         // 'a' == a, o, u, e, y, i
//         foreach (char vovel in vovels) // Получаем гласные
//         {
//             if (symbol == vovel) // Нашли гласную букву
//             {
//                 vovelsCount++; // vovelsCount = vovelsCount + 1
//                 break; // Если нашли гласную, переходим к след.букве
//             }
//         }
//     }
//     return vovelsCount;
// }

// Console.Write("Введите строчку: ");
// string inputString = Console.ReadLine();
// inputString = inputString.ToLower(); // нижний регистр, "HI" -> "hi"
// // ToUpper() - верхний ("hi" => "HI")
// Console.WriteLine($"В строчке: {inputString} в нижн. регистре : {GetVovelsCount(inputString)} гласных");