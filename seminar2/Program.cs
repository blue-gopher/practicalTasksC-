
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// int SecondDigit(int num)
//  {
//     if (num < 100 || num > 999)
//       return -1;
  

//    return num % 100 / 10;
//  }

// System.Console.Write("Enter a three-digit number ");
  
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(SecondDigit(num));


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// void ThirdNumber(int num)
// {
//   if (num < 100)
//   {
//     Console.WriteLine("No third digit");
//   }
//   else
//   {
//     while (num > 999)
//     {
//       num /= 10;
//     }
//     int thirdNum = num % 10;
//     Console.WriteLine($"third digit = {thirdNum}");
//   }
// }

// System.Console.Write("Enter a number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// ThirdNumber(num);

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


// int Prompt() 
// {
//   System.Console.Write("Enter the day of the week: ");
//   int num = Convert.ToInt32(Console.ReadLine());
//   return num;
// }

// bool IsValidDayOfTheWeek(int num) 
// {
//   if (num > 0 && num < 8) 
//   {
//     return true;
//   }
//   return false;
// }

// void IsDayOff(int num) 
// {
//   if (num > 5)
//     Console.WriteLine("this is a day off");
//   else
//     Console.WriteLine("this is NOT a day off");
// }

// int num = Prompt();
// if (IsValidDayOfTheWeek(num))
//   IsDayOff(num);
// else
//   Console.WriteLine("you need to enter the correct data");
