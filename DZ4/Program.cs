//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int CountArray(int lengthArray, int min, int max)
{
    int[] a = new int[lengthArray];
    int count = 0;
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(min, max);
        Console.Write(a[i] + " ");
        if (a[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine();
    return count;
}
Console.Write("Введите длинну массива: ");
int length1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Колличество чётных чисел в масиве = " + CountArray(length1, min, max));
Console.WriteLine();
*/
/*
int Array(int LenghtArray, int min, int max)
{
    int[] a = new int[LenghtArray];
    int sum = 0;
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(min, max+1);
        Console.Write(a[i] + " ");
        if (i % 2 != 0)
        {
            sum = sum + a[i];
        }

    }
    return sum;
}
Console.Write("Введите длинну массива: ");
int length1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите минимальное значение: ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма нечётных элементов масcива = " + Array(length1, min1, max1));
*/

/*
Задача 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и 
минимальным элементов массива.
*/
double[] Array(int num)
{
    double[] a = new double[num];
    for (int i = 0; i < num; i++)
    {
        a[i] = new Random().NextDouble();
        Console.Write(Math.Round(a[i], 2) + " ");
        Console.WriteLine();
    }
    return a;
}
double razniza(double[] Array)
{
    double[] arr = new double[];
    double x = 0;
    double min = 0;
    double max = 0;
    for (int i = 0; i < arr.Lenght; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    x = x + (max - min);
    return x;
}
    Console.Write("Введите размер массива ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.Write(Array(num));
    Console.WriteLine("Разница между минимальным и максимальным элементом массива= " + razniza());


/*double Array(double massiv)
{
    double[] a = new double[8];
    double razniza = 0;
    double min = 0;
    double max = 0;
    for (int i = 0; i < 8; i++)
    {
        a[i] = new Random().NextDouble();
        Console.Write(a[i]);
        if (a[i] > max)
        {
            max = a[i];
        }
        if (a[i] < min)
        {
            min = a[i];
        }
    }
    razniza = razniza + (max - min);
    return razniza;
}
Console.Write("Разница между минимальным и максимальным элементом массива= ", Array(a);
*/
