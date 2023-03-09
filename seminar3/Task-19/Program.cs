// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет         // 12821 -> да         // 23432 -> да
// ---------------------------------------------------------------------------------
// Решение со string для любого диапазона чисел.

// System.Console.Write("Please, enter number: ");
// string num = System.Console.ReadLine();

// bool flag = true;
// int lenNum = num.Length;

// for (int i = 0; i < lenNum / 2; i++) 
// {
//     if (num[i] != num[lenNum - 1 - i])
//     {   
//         flag = false;
//         break;
//     }
// }

// switch (flag) 
// {
//     case true:
//         System.Console.WriteLine("Yes");
//         break;
//     default:
//         System.Console.WriteLine("No");
//         break;
// }
// ----------------------------------------------------------------------------
// Решение c int для любого диапазона чисел.

int ReversNum(int num)
{
    int reversNum = 0;
    while (num > 0) 
    {
        reversNum =reversNum * 10 + (num % 10);
        num /= 10;
    }
    return reversNum;
}

void EnterResult(int num, int reversNum)
{
    switch (num == reversNum) 
    {
        case true:
            System.Console.WriteLine("Yes");
            break;
        default:
            System.Console.WriteLine("No");
            break;
    }
}

System.Console.Write("Please, enter number: ");
int num = Convert.ToInt32(System.Console.ReadLine());

int reversNum = ReversNum(num);
EnterResult(num, reversNum);