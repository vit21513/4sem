//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("введите число ");
int num = Convert.ToInt32(Console.ReadLine());


int Digits(int numbers)    //определяем  из скольки чисел состоит число  и передаем в переменную digit
{
    int digit = 0;
    for (int i = 1; i <= num; i = i * 10)
    {
        digit = digit + 1;
    }
    return digit;
}


int dig = Digits(num);   // переменная хранит число регистров

int[] nums = new int[dig];         // обьявлем массив размером в количество символов введеннного числа


int indexArray = nums.Length - 1;
while (indexArray >= 0)
{
    nums[indexArray] = num % 10;
    num = num / 10;
    indexArray = indexArray - 1;

}


int SumNumber(int digg)
{
    int sumnumb = 0;
    for (int i = 0; i < digg; i++)
    {
        sumnumb = sumnumb + nums[i];
    }
    return sumnumb;
}


int sum = SumNumber(dig);

Console.WriteLine($" сумму цифр в числе составляет  {sum} ");

