// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, 
// b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double HorizontalLineX(double k1, double b1, double k2, double b2)
{
    double b = b2 - b1;
    double k = k1 - k2;
    double x = b/k;
    return x;
}

double VerticalLineY(double x, double k1, double b1)
{
    double y = k1 * x + b1;
    return y;
}

double b1 = 2;
double k1 = 5;
double b2 = 4;
double k2 = 9;
double x = HorizontalLineX(k1, b1, k2, b2);
double y= VerticalLineY(x, k1, b1);
Console.WriteLine($"x = {x:f}");
Console.WriteLine($"y = {y:f}");