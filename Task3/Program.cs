// Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

void PrintArrayNumbers(int[] array, int i)
{
    if (i == array.Length - 1) Console.Write($"{array[i]} ");
    else
    {
        Console.Write($"{array[i]} ");
        PrintArrayNumbers(array, i + 1);
    }
}

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }

    return array;
}

int[] arr = CreateArrayRndInt(10, 1, 10);
PrintArrayNumbers(arr, 0);