// Задача 19. Напишите программу,которая принимает на вход 
//пятизначное число ипроверяет, является ли оно полиндромом.

int number = 12345;
string str = number.ToString();
int size = str.Length;
if (size == 5)
{
    if (str[0] == str[4] && str[1] == str[3])
    {
        Console.WriteLine("True");
    }
    else
    {
        Console.WriteLine("False");
    }
}
else
{
    Console.WriteLine("Число не пятизначное");
    Console.Write("False");
}

