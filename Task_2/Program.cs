/*Задача 43: 
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Вычтем из первого уравнения второе:
0 = (k1-k2)*x + (b1- b2)
x = -(b1 - b2)/(k1 - k2) 
*/
double GetNumber(string message)
{
    Console.WriteLine(message);
    double number = double.Parse(Console.ReadLine()??"");
    return number;
}
(double x, double y) GetPointIntersection(double k1, double k2, double b1, double b2)
{   double x = new double();
    double y = new double();
    if (k1 == k2 && b1 == b2)
        Console.WriteLine("Прямые совпадают.");
    else if(k1 == k2)
        Console.WriteLine("Прямые паралельны, пересечений нет.");
    else
    {
        x = -(b1 - b2)/(k1-k2);
        y = k1 * x + b1;
    }
    return (x,y);
}
void PrintPoint(double x, double y)
{
    Console.WriteLine($"Координаты точки пересечения двух прямых: ({x};{y})");
}
double k1 = GetNumber("Даны две прямые y = k1 * x + b1 и y = k2 * x + b2\nНайти точку пересечения этих прямых\nВведите число k1:");
double k2 = GetNumber("Введите число k2:");
double b1 = GetNumber("Введите число b1:");
double b2 = GetNumber("Введите число b2:");
(double x, double y) = GetPointIntersection(k1, k2, b1, b2);
if(k1!=k2 && b1!=b2)
PrintPoint(x, y);