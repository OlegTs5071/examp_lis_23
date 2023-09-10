//Задача 8: Напишите программу, которая на вход принимает число (N), а на 
//выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8


int[] age = new int[15];
int i = 0;
//int number = i + 1;
while(i < age.Length)
{
    int number = i + 1;
    if (number % 2 == 0)
    {
        Console.Write(number + ", ");
        i++;
    }
    //int number = i + 1;
    i++;        
}





