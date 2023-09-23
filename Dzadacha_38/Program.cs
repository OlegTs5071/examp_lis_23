// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double[] GetNumbers(int length, int minValue, int maxValue)
{
    double[] main = new double[length];
    for (int i = 0; i < main.Length; i++)
    {
        main[i] = new Random().NextDouble() * (maxValue - minValue) + minValue;
    }
    return main;
}

void MinMaxElementArray(double[] array)
{
double min = array[0];
double max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i]>max)
    {
        max = array[i];       
    }
    if (array[i]<min)
    {
        min = array[i];        
    }
}
double result = max - min;
Console.WriteLine($"Min  {min:f}");
Console.WriteLine($"Max  {max:f}");
Console.WriteLine($"Result  {result:f}");
}

void PrintArray(double[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item:f}  ");        
    }
}

//int minValue = -20;
//int maxValue = 20;
//int length = 10;
PrintArray(GetNumbers(length: 5, minValue: -20, maxValue: 20));
Console.WriteLine();
double[] result = { 3.22, 4.2, 1.15, 77.15, 65.2 }; //GetNumbers(length: 5, minValue: -20, maxValue: 20);
MinMaxElementArray(result);
//double total = MinMaxElementArray(array);
//Difference(total);
// int min = -10, max = 10;
// number = new Random().NextDouble() * (max - min) + min;
// Console.WriteLine($"{number:f}");

