//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateTwoDimDoubleArray(int m, int n)
{
    double[,] newMatrix = new double[m,n];
    for(int i = 0; i < m; i++)
        for(int j = 0; j < n; j++)
            newMatrix[i,j] = Math.Round(new Random().Next(-10,11) + new Random().NextDouble(), 1);
    return newMatrix;
}
void ShowTwoDimDoubleArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Input number of lin: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of cols: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
ShowTwoDimDoubleArray(CreateTwoDimDoubleArray(m,n)); 
*/
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateRandomTwoDimArray(int m, int n, int min, int max)
{
    int[,] newMatrix = new int[m,n];

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            newMatrix[i,j] = new Random().Next(min, max + 1);
            Console.Write(newMatrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    return newMatrix;
}
/*
string ValueElement (int[,] array, int lin, int col)
{
    string result = string.Empty; 
    if(lin < array.GetLength(0) && col < array.GetLength(1)) return result += array[lin,col];
    else return "Error. There is no number!";
} 
int[,] myArray = CreateRandomTwoDimArray(4,4,1,9);
Console.Write("Input number of lin: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of cols: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Element value: {ValueElement(myArray, m, n)}"); */

//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
//элементов в каждом столбце.

void ArithmeticMean(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
     {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[j, i];
            sum = sum / array.GetLength(1);
        }
    Console.WriteLine($"Arithmetic mean of the column {i + 1} - {sum}");
     }
 }
int[,] myArray = CreateRandomTwoDimArray(4,4,1,9);
ArithmeticMean(myArray);
