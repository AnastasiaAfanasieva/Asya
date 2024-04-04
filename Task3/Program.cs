// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.
// Пример
// [1, 2 , 5, 0, 10, 34] => 34 10 0 5 2 1


{
    int[] array = GenerateRandomArray(6);
    Console.WriteLine("\t Исходный массив: ");
    Console.WriteLine();
    PrintArray(array);

    Console.WriteLine();

    Console.WriteLine("\t Реверс массива: ");
    Console.WriteLine();
    PrintArrayReverse(array, array.Length - 1);
    Console.WriteLine();

}
static int[] GenerateRandomArray(int size)
{
    int[] randomArray = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        randomArray[i] = rnd.Next(10, 100);
    }

    return randomArray;
}
static void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }


}
static void PrintArrayReverse(int[] array, int index)
{
    if (index >= 0)
    {
        Console.Write(array[index] + " ");
        PrintArrayReverse(array, index - 1);
    }
}

