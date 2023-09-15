//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

//int day = Convert.ToInt32(Console.ReadLine()!);
int[] dayArray = {1, 2, 3, 4, 5, 6, 7};
int N = dayArray.Length;
int i = 0;
while (i < N)
{
    if (dayArray[i] > 5)
        {
            Console.WriteLine("да");
            i++;
        }
    else
        {
            Console.WriteLine("нет");
            i++;
        }   
    
}


