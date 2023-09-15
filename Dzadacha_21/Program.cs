//Задача 21. Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.

int[] ReadPointACoords()
{
    int x = 3;
    int y = 6;
    int z = 8;
    int[] point = new int[] { x, y, z };
    return point;
}
int[] ReadPointBCoords()
{
    int x = 2;
    int y = 1;
    int z = -7;
    int[] point = new int[] { x, y, z };
    return point;
}
double DistanceBetweenPoints(int[] pointA, int[] pointB)
{
    int x1 = pointA[0];
    int x2 = pointA[1];
    int x3 = pointA[2];
    int y1 = pointB[0];
    int y2 = pointB[1];
    int y3 = pointB[2];
    int distance1 = x3 - y3;
    int distance2 = x1 - y1;
    int katet2 = x2 - y2;
    double katet1 = Math.Sqrt(distance1 * distance1 + distance2 * distance2);
    double result = Math.Sqrt(katet1 * katet1 + katet2 * katet2);
    return result;

}
int[] pointA = ReadPointACoords();
int[] pointB = ReadPointBCoords();
Console.WriteLine(DistanceBetweenPoints(pointA, pointB));