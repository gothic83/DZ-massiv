//Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, 
//начинающихся на гласную букву.
/*string[] words = { "апельсин", "яблоко", "хурма", "дом", "пенал", "игорь", "дверь","алфавит","yandex","почка"};
int count1(string[] words)
{
    string[] a = { "а", "е", "ё", "и", "о", "у", "ы", "э", "ю", "я", "a", "e", "i", "o", "u", "y" };
    int count = 0;
    for (int i = 0; i < words.Length; i++)
    {
        for (int j = 0; j < a.Length; j++)
            if (words[i][0] == a[j][0])
            {
                count++;
            }
    }
    return count;
}
Console.WriteLine("Колличество слов на глассную букву = " + count1(words));
*/
string[] words = { "апельсин", "яблоко", "хурма", "дом", "пенал", "игорь", "дверь","алфавит","yandex","почка"};
string []para(string[] array)
{
    int size = array.Length / 2;
    string[] newArr = new string[size];
    for (int i = 0, j = 0; i < array.Length - 1; i += 2, j++)
    {
        newArr[j] = array[i] + array[i + 1];
    }
    return newArr;
}
void ShowArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    } 
    Console.WriteLine();
}
Console.WriteLine("Склеивание слов попарно = " + ShowArray(para(words)));
