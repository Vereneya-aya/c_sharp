// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные 
// числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

// void ShowNumbers(int M, int N)
// {
//     if (M == N) 
//     {
//         Console.Write(M);
//         return;
//     }
//     Console.Write(M + " ");
//     ShowNumbers(M + 1, N);
// }
// Console.WriteLine("Введите M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Натуральные числа от М до N:");
// ShowNumbers(M, N);

//Задача 2: Напишите программу вычисления функции 
//Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

// int Ackermann(int n, int m)
// {
//     if (n == 0)
// {
//     return m + 1;
// }
// else
// {
//     if (m == 0)
//     {
//         return Ackermann(n - 1, 1);
//     }
//     else
//     {
//         return Ackermann(n - 1, Ackermann(n, m - 1));
//     }
// }
// }

// Console.WriteLine("Введите неотрицательное число n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите неотрицательное число m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Результат вычисления функции Аккермана для n и m: {Ackermann(n, m)}");


// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

// int[] array = { 1, 2, 3, 4 }; =>  4, 3, 2, 1

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 101);
    }
    return array;
}

void PrintReverseArray(int[] array, int j)
{
    if (j == 0)
    {
        Console.Write(array[j]);
        return;
    }
    Console.Write(array[j] + ", ");
    PrintReverseArray(array, j - 1);
}

int[] array = CreateArray(5);
Console.WriteLine($"Исходный массив: [ {string.Join("; ", array)} ]");
int j = array.Length - 1;
Console.WriteLine($"Его элементы, начиная с конца: ");
PrintReverseArray(array, j);