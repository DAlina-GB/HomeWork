//Задача №1
//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*Console.WriteLine();
Console.Write("Input the length of the array: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];

void FillArray(int[] array)
{
  for (int i = 0; i < num; i++ )
  {
    array[i] = new Random().Next(100,1000);
  }
}

void WriteArray(int[] array)
{
    for (int i = 0; i < num; i++ )
    {
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

int PositiveNumber(int[] array)
{
    int num2 = 0;
    for (int i = 0; i<num; i++ )
    {
    if (array[i] % 2 == 1)
    {
      num2++;
    }
  }
  return num2;
}

Console.WriteLine();
FillArray(array);
WriteArray(array);
Console.WriteLine();
int num2 = PositiveNumber(array);
Console.Write($"Quantity positive numbers in the array: {num2}"); */


//Задача №2
//Задайте одномерный массив,
//заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*
Console.Write("Input the length of the array: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];

void FillArray(int[] array)
{
  for (int i = 0; i < num; i++ )
  {
    array[i] = new Random().Next(100,1000);
  }
}
void Array2(int[] array)
{
    int sum = 0;
    Console.WriteLine();
    for (int i = 0; i < num; i++)
    {
        Console.Write(array[i] + " ");
        if (i % 2 > 0) sum += array[i];
    }
   Console.WriteLine();
    Console.WriteLine($"Sum of negative positions {sum} ");

}
FillArray(array);
Array2(array); 
*/
//Задача №3
//Задайте массив вещественных(дробных, см. Random().NextDouble()) чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

void FillArray(double[] Array2)
{
    for (int i = 0; i < Array2.Length; i++)
    {
        Array2[i] = new Random().NextDouble()* 100;
        Console.Write(Array2[i] + " "); 
    }
    Console.WriteLine();
    double max = Array2[0];
    double min = Array2[0];
   
    for (int i = 0; i < Array2.Length; i++)
    {
        if(Array2[i] > max) max = Array2[i];
        if(Array2[i] < min) min = Array2[i];
    }
    Console.Write($"{max} - {min} = {max - min}");
}

double[] Array = new double[3];
FillArray(Array);


    