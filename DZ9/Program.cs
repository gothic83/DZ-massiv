//66.Задайте значения M и N. Напишите программу, которая найдёт 
//сумму натуральных элементов в промежутке от M до N.
/*int Summa(int m, int n)
{
if (m==n) return m;
else return m+Summa (m+1,n);
}
Console.Write("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма элементов от m до n= " + Summa(m,n));
*/

//67. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
int Summa(int m)
{
    if (m < 10)
    {
        return m;
    }
    else
    {
        return m % 10 + Summa(m / 10);
    }
}
Console.Write("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма цифр числа m = " + Summa(m));