// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
Console.Write("введите значение b1 :");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите значение k1 :");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите значение b2 :");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите значение k2 :");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b1-b2)/(k2-k1);
double y = ((k2*b1)-(k1*b2))/(k2-k1);

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}; Y: {y}");
