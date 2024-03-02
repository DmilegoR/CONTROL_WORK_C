//  Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше, либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения
// алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

string[] source = { "one", "two", "34", "District", "Vi", "один", "Book", "Woo", "Normal" };

void PrintArray(string[] m)
{
    for (int x = 0; x < m.Length; x++)
        Console.Write($"\"{m[x]}\" ");
    Console.WriteLine();
}
string[] copyStringsBelowOrEqual3InNewArray(string[] strArray)
{
    int k = 0;
    for (int i = 0; i < strArray.Length; i++)
        if (strArray[i].Length <= 3) k++;
    string[] newArray = new string[k];
    k = 0;
    for (int i = 0; i < strArray.Length; i++)
        if (strArray[i].Length <= 3) newArray[k++]=strArray[i];

    return newArray;
}

Console.WriteLine("Исходный массив строк:");
PrintArray(source);
string[] target = copyStringsBelowOrEqual3InNewArray(source);
Console.WriteLine("Результат:");
PrintArray(target);
Console.WriteLine();