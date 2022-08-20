// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Clear();
double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.NextDouble() * (max - min) + min;
    }
    return array;
}

double DiffMaxMin(double[] array)
{
    double minimum = array[0];
    double maximum = array[0];
    //  double result = (maximum - minimum);
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minimum)
        {
            minimum = array[i];
        }
        if (array[i] > maximum)
        {
            maximum = array[i];
        }
    }
    double result = maximum - minimum;
    return result;
}
double[] arr = CreateArrayRndDouble(7, -5, 20);
double diffMaxMin = DiffMaxMin(arr);

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{Math.Round(array[i], 2)}, ");
        else Console.Write(Math.Round(array[i], 2));
    }
    Console.Write("]");
    Console.Write($" -> {Math.Round(diffMaxMin, 2)}");
}

PrintArray(arr);
