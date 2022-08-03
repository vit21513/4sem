//Задача 29: Напишите программу, которая задаёт массив из 8 элементов, заполненный
//псевдослучайными числами и выводит их на экран.
//
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//
//6, 1, 33 -> [6, 1, 33]

int[] array = GetRndArray(8);


int[] GetRndArray(int arrayLength)
{
    Random rnd = new Random();
    int[] arr = new int[arrayLength];

   for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0,100);
    }
    return arr;
}

void WriteArrayToConsole(int[] array)
{
   Console.Clear();
   Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i != array.Length -1)
            Console.Write(",");
    }
   Console.WriteLine("]");    
}

WriteArrayToConsole(array);