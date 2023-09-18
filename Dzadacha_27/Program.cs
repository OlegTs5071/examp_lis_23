// Задача 27: Напишите программу, которая принимает на вход число
//  и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int InputNumber(string message)
{
    Console.Write(message);
    string text = Console.ReadLine();
    int result = int.Parse(text);
    return result;
}

int SumNumbers(int number_in)
{
    int sum = 0;
    while (number_in > 0)
    {
        sum = sum + number_in % 10;
        number_in = number_in / 10;
    }
    return sum;
}

int number_in = InputNumber("Введите число:");

Console.Write($"Сумма всех цифр в {number_in} = {SumNumbers(number_in)}");