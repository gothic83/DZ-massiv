/*// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateArray(int m, int n)
{
    double[,] randomArray = new double[m, n];
    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            randomArray[i, j] = new Random().NextDouble();
            Console.Write(Math.Round(randomArray[i, j], 2) + " ");
        }
        Console.WriteLine();
    }
    return randomArray;
}
Console.Write($"Iput m number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"Iput n number: ");
int n = Convert.ToInt32(Console.ReadLine());
CreateArray(m, n);
*/
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
/*int[,] RandomArray()
{
    int[,] Array = new int[5, 10];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(1, 50);
            Console.WriteLine();
        }
    }
        return Array;
 }   
    void ShowElement(int[,] array, int pos1, int pos2)
    {
        int a = array.GetLength(0);
        int b = array.GetLength(1);
        if (pos1 <= a && pos2 <= b && pos1 > 0 && pos2 > 0)
        {
            Console.WriteLine($"Элемент на позиции  {pos1} {pos2} = {array[pos1 - 1, pos2 - 1]}");
        }
        else
        {
            Console.WriteLine($"Не найден элемент на позции {pos1} {pos2}");
        }
    }
    Console.Write("Input first position: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input second position: ");
    int y = Convert.ToInt32(Console.ReadLine());
    ShowElement(RandomArray(), x, y);
*/
//Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
int[,] CreateArr()
{
    int[,] arr = new int[4,4];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 30);
            Console.Write(arr[i, j] + " | ");
        }
        Console.WriteLine();
    }
    return arr;
}
int[] SrArrifm(int[,] array)
{
    int sum = 0;
    int size = array.GetLength(0);
    int[] average = new int[array.GetLength(1)];
    int a = 0;
    for (int i = 0; i < average.Length; i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, a];
            for (int k = 0; k < array.GetLength(1); k++)
            {
                average[i] = sum / size;
            }
        }
        a++;
        sum = 0;
    }
    return average;
}
void PrintResult(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write(a[i] + " | ");
    }
        Console.Write("<<Среднее арифметическое столбцов ");
        Console.WriteLine();
}
PrintResult(SrArrifm(CreateArr()));