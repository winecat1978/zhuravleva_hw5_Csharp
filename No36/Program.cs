// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] ArrayCreation (int length)
{
    int [] arr = new int [length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr [i] = rnd.Next(-100, 101);
    }
    return arr;
}

int DetermSumm (int length, int [] array)
{
    int summ = 0;
    for (int i = 0; i < length; i++)
    {
        if(i%2 == 1)
        {
            summ += array[i];
        }
    }
    return summ;
}


Console.WriteLine("Введите размерность массива: ");
int length = int.Parse(Console.ReadLine());
int [] array = ArrayCreation(length);
Console.WriteLine(string.Join(" ", array));
int result = DetermSumm(length, array);
Console.WriteLine($"Сумма элементов массива на нечетных позициях равна {result}");
