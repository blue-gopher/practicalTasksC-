// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int PowAtoB(int A, int B) 
{
    int mult = A;
    for (int i = 0; i < (B-1); i++) 
    {
        mult *= A;
    }
    return mult;
}

Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число В: ");
int B = Convert.ToInt32(Console.ReadLine());

int result = PowAtoB(A, B);
Console.WriteLine($"{A} в сетепи {B} = {result}");


