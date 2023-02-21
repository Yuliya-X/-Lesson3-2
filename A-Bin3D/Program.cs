//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

// ввод данных пользователем +
int Input(string number)
{
    Console.Write(number + " ");
    return Convert.ToInt32(Console.ReadLine());
}

//int Dist()

//int x1 = 3; 
//int y1 = 6; 
//int z1 = 8;
//int x2 = 2; 
//int y2 = 1; 
//int z2 = -7;
{
   // int distance = ((x2 - x1)^2 + (y2 - y1)^2 + (z2 - z1)^2)^0.5;
  //  return distance;
}

//Console.WriteLine(distance);
//Dist();

int Main() 
{
  
  Console.Write("Введите число: "); // которое программа возводит в степень + 
  int num = Convert.ToInt32(Console.ReadLine());
  return num;
}
  //степень числа
 // Console.Write("Введите степень: ");
  //int n = int.Parse(Console.ReadLine());
  //int n = 0;
  //число, возведенное в степень
  
void InCybic(int number)
{
    int InCybic;
  for(int i = 1; i <= number; i++) 
  {
    InCybic = i * i * i;
    Console.Write($"{InCybic} ");  
  }
  
  //Console.WriteLine("{0} ^ {1} = {2}", num, n, num_n);
  //Console.ReadKey();
}

int num = Main();
Console.Write($"Таблица кубов: ");
// Console.WriteLine($"Таблица кубов: ");
InCybic(num);



