// //Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double b1 = ReadInt("Введите точку b1: ");
double k1 = ReadInt("Введите точку k1: ");
double b2 = ReadInt("Введите точку b2: ");
double k2 = ReadInt("Введите точку k2: ");
double x = 0;
double y = 0;

if(k1 == k2)
{
    Console.WriteLine("Точки пересечения нет!");
}
else
{
     x = (-b1 + b2) / (k1 - k2);
    y = k1 * x + b1;
    Console.WriteLine($"({x}; {y};)");
}


double ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}