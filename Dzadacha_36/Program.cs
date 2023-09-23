// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray(int length, int minValue = 10, int maxValue = 99)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int[] CreatArray(int[] massive, int length)
{
    int[] two = new int[length];
    for (int i = 0; i < massive.Length; i++)
    {
        if (i % 2 == 0)
        {

        }
        else
        {
            two[i] = massive[i];
        }
    }
    return two;
}

int SumElements(int[] elements)
{
    int sum = 0;
    for (int i = 0; i < elements.Length; i++)
    {
        sum = sum + elements[i];
    }
    return sum;
}

void PrintArray(int[] array)
{
foreach (var item in array)
{
    Console.Write(item + " ");
}
}

int length = 10;
int[] massive = GetArray(length, minValue: -20, maxValue: 100);
int[] elements = CreatArray(massive, length);
PrintArray(massive);
Console.WriteLine();
Console.WriteLine(SumElements(elements));

