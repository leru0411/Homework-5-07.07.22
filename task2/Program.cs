// Задача 2: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
int[] GenerateArray(int length, int min, int max)
{
    int[] newArray = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rnd.Next(min, max + 1);
    }
    return newArray;
}
void PrintMassive(int[] array)
{
    System.Console.Write("[");
    System.Console.Write(array[0]);
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write(", " + array[i]);
    }
    System.Console.WriteLine("]");
}

int SumNums(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)         //нечетная позиция соответствует четному индексу (1е число под индексом 0, 2е под индексом 1 т.д.)
        {
            result+=array[i];
        }
    }
    return result;
}

int[] list = GenerateArray(5, 1, 5);
PrintMassive(list);
int sum = SumNums(list);
System.Console.WriteLine(sum);