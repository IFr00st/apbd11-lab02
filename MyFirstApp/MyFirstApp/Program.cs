// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Mod 1");
Console.WriteLine("Mod 2");
Console.WriteLine("Mod 3");

int[] arr = { 1, 2, 3, 4, 5 };
Console.WriteLine(GetAverage(arr));

Console.WriteLine(GetMax(arr));

static double GetAverage(int[] numbers)
{
    double sumaa = 0;
    foreach(int x in numbers)
    {
        sumaa += x;
    }

    return sumaa / numbers.Length;
}

static int GetMax(int[] numbers)
{
    int temp = numbers[0];
    foreach (var VARIABLE in numbers)
    {
        if (VARIABLE > temp)
        {
            temp = VARIABLE;
        }
    }

    return temp;
}