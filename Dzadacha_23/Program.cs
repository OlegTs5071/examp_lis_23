//Задача 23. Напишите программу которая принимает на вход 
//число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 4, 9
//5 -> 1, 8, 27, 64, 125


int N = 9;
int i = 0;
int[] age = new int[N];
while (i < N)
{
    int number = i + 1;
    int result = number * number * number;
    Console.WriteLine(result);
    i++;
}

