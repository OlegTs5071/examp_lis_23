/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных 
чисел. Напишите программу, которая будет построчно выводить массив, добавляя
 индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
int[,,] GetArray(int rows, int cols, int vols, int minValue = 1, int maxValue = 9)
{
    int[,,] array = new int[rows, cols, vols];
    for (int i = 0; i < array.GetLength(0); i++)
	{
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                for (int n = k; n < array.GetLength(2) - 1; n++)
                {
                    if (array[i, j, n] == array[i, j, n + 1])
                    array[i, j, k] = array[i, j, n + 1];
                }
                
                array[i, j, k] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }

	return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
	{
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        //Console.WriteLine();
    }
    Console.WriteLine();	
}

int rows = 2;
int cols = 2;
int vols = 2;
PrintArray(GetArray(rows, cols, vols, minValue: 10, maxValue: 99));
