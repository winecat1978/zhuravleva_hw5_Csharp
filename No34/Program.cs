// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] ArrayCreation (int length)
{
    int [] arr = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(100,1000);
    }
    return arr;
}

int Counter_numbers (int length, int [] array)
{
    int counter = 0;
    for (int i = 0; i < length; i++)
    {
        if(array[i]%2 == 0)
        {
            counter+=1;
        }
    }
    return counter;
}

Console.WriteLine("Введите размерность массива: ");
int length = int.Parse(Console.ReadLine());
int [] array = ArrayCreation(length);
Console.WriteLine(string.Join(" ", array));
int result = Counter_numbers(length, array);
Console.WriteLine($"В массиве содержится {result} четных чисел");