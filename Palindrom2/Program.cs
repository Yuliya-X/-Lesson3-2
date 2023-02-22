// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// ввод данных пользователем +
int Input(string number)
{
    Console.Write(number + " ");
    return Convert.ToInt32(Console.ReadLine());
}

// проверка введенного значения 
void isPalindrome() 
{
   
   int N = Input("Введите пятизначное число: ");
   int N5 = N % 10;
   int N1 = N / 10000;
   int N2 = N / 1000;
   int N4 = N % 100;
   // Двигаемся с обоих концов серидине
        
        if (N1 == N5 || N2 == N4) // Сравниваем символы попарно
            Console.WriteLine("Да");
        
            
        else
        {
            Console.WriteLine("Нет");      
        }
}

isPalindrome();