/*
Задача 41: Пользователь вводит с клавиатуры M чисел.
 Посчитайте, сколько чисел больше 0 ввёл пользователь.int Zero(int[] a)
{
    int count = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] > 0) count++;
    }
    return count;
}
int[] CreateArray(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите " + (i+1) + "-й номер: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
Console.Write("Введите колличество номеров: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Количество номеров больше нуля = {Zero(CreateArray(n))}");
*/

//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
/*string a(int num)
{
    string result = String.Empty;
    while (num > 0)
    {
        result += Convert.ToString((num % 2));
        num = num/2;
    }
    result = new string (result.Reverse().ToArray());
    return  result;
}
Console.Write("Введите номер для перевода из десятичной в двоичную систему: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введённое число в двоичной систему = {a(num2)}");
*/

// Последняя задача слишком мне не понятна. даже если найти формулу.