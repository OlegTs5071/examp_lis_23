// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество
//  чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray(int length, int minValue = 10, int maxValue = 99)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int AllEvenNumbers(int[] massive)
{
    int count = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] array)
{
    /*for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();*/
foreach (var item in array)
{
    Console.Write(item + " ");
}
}
Console.WriteLine();
int length = 10;
int[] massive = GetArray(length, minValue: 100, maxValue: 1000);
int count = AllEvenNumbers(massive);
PrintArray(massive);
Console.WriteLine();
Console.WriteLine(count);
