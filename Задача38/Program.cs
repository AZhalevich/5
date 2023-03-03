// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

double[] GetArray(int size, double minValue, double maxValue)
{
    double[] result = new double[size];

    for ( int i = 0; i < size; i++)
    {
        result[i] = Math.Round(new Random().NextDouble() * (maxValue - minValue) + minValue, 2 );
    }
    return result;
}

double Max(double[] array)
{
    double max = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        max = array[i];
    }
    return max;
}

double Min(double[] array)
{
    double min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        min = array[i];
    }
    return min;
}

double[] array = GetArray(10, -20, 20);
Console.WriteLine(string.Join(", ", array));
double min = Min(array);
double max = Max(array);
Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значениями = {Math.Round(max - min, 2)}");
