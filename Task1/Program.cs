// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.
// Пример
// M = 1; N = 5 => "1, 2, 3, 4, 5"
// M = 4; M = 8 => "4, 5, 6, 7, 8"

string OutputNumbers(int m, int n)
{
    if (n == m)
        return $"{m}";
    return OutputNumbers(m, n - 1) + $", {n}";
}


Console.Clear();
Console.Write("Введите 1-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(OutputNumbers(m, n));