// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] GenerateArray(int length, int min, int max)
{
    double[] NewArray = new double[length];
    Random rnd = new Random();
    for (int i = 0; i < NewArray.Length; i++)
    {
        NewArray[i] = rnd.Next(min, max) + rnd.NextDouble();
    }
    return NewArray;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + ";");
    }
    System.Console.WriteLine();
}

double DiffMinMax(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        else if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max - min;
}
double[] list = GenerateArray(10, 1, 50);
PrintArray(list);
double different = DiffMinMax(list);
System.Console.WriteLine(different);
