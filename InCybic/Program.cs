// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// 1. ввод числа пользователем 
int Main() 
{
  Console.Write("Введите число: "); // которое программа возводит в степень + 
  int num = Convert.ToInt32(Console.ReadLine()); 
  return num;
}

// 2. возведение в степень 
void InCybic(int number)
{
    int InCybic;
  for(int i = 1; i <= number; i++) 
  {
    InCybic = i * i * i;
    Console.Write($"{InCybic} ");  
  }
    
// Console.WriteLine("{0} ^ {1} = {2}", num, 3, InCybic(num)); //- не рабоатет, надо разобаться! 
}

int num = Main();
Console.Write($"Таблица кубов: ");
// Console.WriteLine($"Таблица кубов: ");
InCybic(num);