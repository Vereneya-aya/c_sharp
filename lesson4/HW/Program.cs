 string GetNumbers(string s)
{
    string numbers = "";
    foreach (char e in s)
    {
        if (char.IsNumber(e) == true)
        {
            numbers = numbers + ", " + e;
        }
    }
    return numbers;
}

string str = Console.ReadLine();
string semires = GetNumbers(str);
// int numbers = Convert.ToInt32(semires);


//  int[]array = new int [];
// while (numbers > 0)
//  {
//     int j=size-1;
//    int digit = numbers %10;
//     numbers /= 10;
//    array[j]=digit;
//  }
Console.WriteLine($"Массив: [{semires}]");
