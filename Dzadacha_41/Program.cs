// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] GetArrayNumbers(int M)
{
    int[] array = new int[M];
    for (int i = 0; i < M; i++)
    {
        Console.WriteLine("Введите число");
        array[i] = Convert.ToInt32(Console.ReadLine()!);
    }
    return array;
}

int CountNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;            
        }
    }
    return count;              
}

int M = 6;
int[] massive = GetArrayNumbers(M);
int number = CountNumber(massive);
Console.WriteLine(number);

