// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int len = 10;
int min = -10;
int max = 10;

double[] rand = FillArrayD(len, min, max);
PrintArray(rand);

Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {FindDiffMinMax(rand)}");

double[] FillArrayD(int n, int min, int max)
{
    double[] array = new double[n];
    double fract = 0;
    for (int i = 0; i < n; i++)
    {
        fract = new Random().Next(0, 100);
        fract = fract / 100;
        array[i] = new Random().Next(min, max + 1) + fract;
    }
    return array;
}

void PrintArray(double[] array)
{
    int n = array.Length;
    for (int i = 0; i < n; i++)
    {
        if (i == n - 1) Console.WriteLine($"{array[i]}");
        else Console.Write($"{array[i]}, ");
    }
}

double FindDiffMinMax(double[] array)
{
    int n = array.Length;
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < n; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    double diff = max - min;
    return diff;
}