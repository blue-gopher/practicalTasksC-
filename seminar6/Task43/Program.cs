// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void FindIntersectionPoint(int b1, int k1, int b2, int k2)
{
    if (k1 == k2 && b1 != b2) 
    {
        Console.WriteLine("Прямые распаложенны параллельно!");
        return;
    } 

    if (k1 == k2 && b1 == b2) 
    {
        Console.WriteLine("Прямые Лежат друг на друге!");
        return;
    }

    double x = Convert.ToDouble(b2- b1) / Convert.ToDouble(k1-k2); 
    double y = Convert.ToDouble(k1) * x  + b1;
    Console.WriteLine($"({x}, {y})");
}

Console.Write("Введите число b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

FindIntersectionPoint( b1,  k1,  b2,  k2);
