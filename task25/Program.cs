//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("Введите первое число ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int secondNum = Convert.ToInt32(Console.ReadLine());


int ResDegree(int first, int second)
{
    int degree = 1;
    for (int i = 1; i <= second; i++)
    {
        degree = degree * first;
    }
    return degree;
}
int result = ResDegree(firstNum, secondNum);

Console.WriteLine($"натуральная  степень составляет  {result}");