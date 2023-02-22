//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

// double distance = ((x2 - x1)^2 + (y2 - y1)^2 + (z2 - z1)^2)^0.5; - как вычесть корень?! - Math.Sqrt()
// return distance;
//Console.WriteLine($"{distance}");

// вовдим координаты для посчета дистанции по формуле
double Main(string[] args)
{
double x1, y1, z1;
double x2, y2, z2;
double distance;
    Console.WriteLine("Ведите данные по инстукции: ");
    Console.WriteLine("Введите значения для точки А: ");
    Console.Write("x1 =" + " ");
    x1 = double.Parse(Console.ReadLine());
    Console.Write("y1 =" + " ");
    y1 = double.Parse(Console.ReadLine());
    Console.Write("z1 =" + " ");
    z1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите значения для точки В: ");
    Console.Write("x2 =" + " ");
    x2 = double.Parse(Console.ReadLine());
    Console.Write("y2 =" + " ");
    y2 = double.Parse(Console.ReadLine());
    Console.Write("z2 =" + " ");
    z2 = double.Parse(Console.ReadLine());
// формула вычисления дистаниции 
    distance = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1) + (z2 - z1)*(z2 - z1));
    return distance;
}
double distance = Main(args);
Console.WriteLine($"Дистанция между А и В составляет: ");
Console.WriteLine($"{distance}");