// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Mod 1");
Console.WriteLine("Mod 2");
Console.WriteLine("Mod 3");

int[] arr = { 1, 2, 3, 4, 5 };
Console.WriteLine(GetAverage(arr));

static double GetAverage(int[] numbers)
{
    double sum = 0;
    foreach(int x in numbers)
    {
        sum += x;
    }

    return sum / numbers.Length;
}