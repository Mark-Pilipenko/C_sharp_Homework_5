// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int len = 10;
int min = -10;
int max = 10;

int[] rand = FillArray(len, min, max);
PrintArray(rand);

Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях равна {SumOddIndex(rand)}");

int[] FillArray(int n, int min, int max)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    int n = array.Length;
    for (int i = 0; i < n; i++)
    {
        if (i == n - 1) Console.WriteLine($"{array[i]}");
        else Console.Write($"{array[i]}, ");
    }
}

int SumOddIndex(int[] array)
{
    int n = array.Length;
    int sum = 0;
    for (int i = 1; i < n; i += 2)
    {
        sum = sum + array[i];
    }
    return sum;
}