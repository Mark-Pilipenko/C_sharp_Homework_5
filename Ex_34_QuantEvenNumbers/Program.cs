// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int len = 10;
int min = 100;
int max = 999;

int[] rand = FillArray(len, min, max);
PrintArray(rand);

Console.WriteLine($"Количество четных чисел равно {QuantEvenNum(rand)}");

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

int QuantEvenNum(int[] array)
{
    int n = array.Length;
    int count = 0;
    for (int i = 0; i < n; i++)
    {
        if (array[i] % 2 == 0) count += 1;
    }
    return count;
}