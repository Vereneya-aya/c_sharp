// TASK 1
//int[,] matrix = new int[3, 5];
// Random rnd = new Random();
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = rnd.Next(1, 11);
//     }
// }
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }

// int[,] CreateMatrix(int rowCount, int columsCount)
// {
//     int[,] matrix = new int[rowCount, columsCount];

//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(1, 11);
//         }
//     }
//     return matrix;
// }

// void ShowMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] matrix = CreateMatrix(4, 5);
// ShowMatrix(matrix);

// TASK 2

// int[,] CreateMatrix(int rowCount, int columsCount)
// {
//     int[,] matrix = new int[rowCount, columsCount];

//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(1, 1000);
//         }
//     }
//     return matrix;
// }
// void ShowMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] matrix = CreateMatrix(3, 4);
// ShowMatrix(matrix);
// foreach (int e in matrix)
// {
//     if(isInteresting(e)==true)
//     {
//         Console.WriteLine(e);
//     }
// }

// bool isInteresting(int value)
// {
//     int sumOfDigits = GetSumOfDigits(value);
//     if (sumOfDigits % 2 == 0)
//     {
//         return true;
//     }
//     return false;
// }

// int GetSumOfDigits(int value)
// {
//     int sum = 0;
//     while (value > 0)
//     {
//         sum = sum + value % 10;
//         value = value / 10;
//     }
//     return sum;
// }

// Task 3
// string GetLetters(string s)
// {
//     string letters = "";
//     foreach (char e in s)
//     {
//         if (char.IsLetter(e) == true)
//         {
//             letters = letters + e;
//         }
//     }
//     return letters;
// }

// string str = Console.ReadLine();
// string result = GetLetters(str);
// Console.WriteLine(result);
