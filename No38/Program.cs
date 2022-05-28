// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
int [] ArrayCreation(int length)
{
    int [] arr = new int [length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr [i] = rnd.Next(0,101);
    }
    return arr;
}

int LookingForMax(int length, int [] array)
{
    int max= array[0];
    for (int i = 0; i < length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

int LookingForMin(int length, int [] array)
{
    int min = array[0];
    for (int i = 0; i < length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

Console.WriteLine("Введите размерность массива: ");
int length = int.Parse(Console.ReadLine());
int [] array = ArrayCreation(length);
Console.WriteLine(string.Join(" ", array));
int Max = LookingForMax(length, array);
Console.WriteLine("max = " + Max);
int Min = LookingForMin(length, array);
Console.WriteLine("min = " + Min);
int result = Max - Min;
Console.WriteLine($"Разница максимального и минимального значения равна {result}");