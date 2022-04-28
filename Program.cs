/* Задача 1: Напишите цикл, который принимает на вход два числа (A и B)
 и возводит число A в натуральную степень B.
Console.Write("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());
int count = 0;
int result = 1;
while (count != b)
{
    result = result*a;
    count++;
}
Console.WriteLine("Результат возведения первого числа в степень второго числа =  " + result);
*/
// Задача 2: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
/*
Console.Write("Введите номер: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = 0;
while (num / 10 != 0)
{
    result = result+num % 10;
    num = num/10;
}
result = result + num;
Console.WriteLine("Сумма цифр введённого числа = " + result); 
*/
// Задача 3: Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.
int[] array = new int[8];
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 51);
}
for (int i = 0; i < array.Length-1; i++)
{
    Console.Write(array[i] + ", ");
}
Console.Write(array[7] + "]");
Console.WriteLine();
Console.Write("[");
for (int j = 0; j < array.Length -4; j++)
{
    Console.Write(array[j] + ", ");
}
Console.Write(array[4] + "]");
Console.WriteLine();
Console.Write("[");
for (int x = 5; x<array.Length-1; x++)
{
    Console.Write(array[x] + ", ");
}
Console.Write(array[7] + "]");
Console.WriteLine();