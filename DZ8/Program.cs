// Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
/*int[,] CreateArray(int size1, int size2)
{
    int[,] randomArray = new int[size1, size2];
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            randomArray[i, j] = new Random().Next(1, 31);
             Console.Write(randomArray[i, j] + " ");
        }
        Console.WriteLine();
    }
    return randomArray;
}
    
int[,] SortString(int[,] array)
{
    for (int k = 0; k < array.GetLength(1); k++)
    {
        int x = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (array[x, j] > array[x, j + 1])
                {
                    int temp = array[x, j];
                    array[x, j] = array[x, j + 1];
                    array[x, j + 1] = temp;
                }
            }
            x++;
        }
    }
    return array;
}
void ShowSortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.Write("Input strings count: ");
int strings = Convert.ToInt32(Console.ReadLine());
Console.Write("Input columns count: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] newArray = CreateArray(strings, columns);
Console.WriteLine();
ShowSortArray(SortString(newArray));
*/
// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*int[,] CreateArray(int a, int b)
{
    int[,] array = new int[a, b];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 31);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}
int[] SumString(int[,] array)
{
    int[] sum = new int[array.GetLength(0)];
    int a = 0;
    int summa = 0;
    for (int i = 0; i < sum.Length; i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                summa = summa + array[a, k];
                sum[i] = summa;
            }
            summa = 0;
        }
        a++;
    }
    return sum;
}
void PrintSum(int[] sum)
{
    for (int i = 0; i < sum.Length; i++)
    {
        Console.Write("Summa element string № " + (i + 1) + " = ");
        Console.Write(sum[i] + " ");
        Console.WriteLine();
    }

}
int MinSumString(int[] sum)
{
    int min = sum[0];
    int minIndex = 0;
    for (int i = 0; i < sum.Length; i++)
    {
        if (sum[i] <= min)
        {
            min = sum[i];
            minIndex = i + 1;
        }
    }
    return minIndex;
}
int[,] array = CreateArray(6, 4);
Console.WriteLine();
PrintSum(SumString(array));
Console.WriteLine();
Console.WriteLine("Minimum sum element in string" + " " + MinSumString(SumString(array)));
*/

// Задача 62. Заполните спирально массив 4 на 4.
//Не... это вне границ моего развития... я посмотрел как решали эту задачу другие, но
//  всё равно не понял как они к этому пришли.а тупо списывать не хочу. это не имеет никакого смысла.