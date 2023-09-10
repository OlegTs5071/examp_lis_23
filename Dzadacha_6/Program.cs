//Задача 6: Напишите программу, которая на вход принимает число и 
//выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

int digit = Convert.ToInt32(Console.ReadLine()!);
int digit2 = digit % 2;
if (digit2 == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}