// Задача 25: Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int FirstNumber(string symbols)
{
    Console.Write(symbols);
    string num = Console.ReadLine();
    int result = int.Parse(num);
    return result;
}

int ExpoDigitNumber(int numberA, int numberB)
{
    int result = 1;
    for (int i = 0; i < numberB; i++)
    {
        result = numberA * result;
    }
    return result;

}
int numberA = FirstNumber("Введите число ");
int numberB = FirstNumber("Введите число ");
Console.WriteLine($"Число {numberA} в степени {numberB} = {ExpoDigitNumber(numberA, numberB)}");
