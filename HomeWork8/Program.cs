int[,] CreateRandomTwoDimArray(int m, int n, int min, int max)
{
    int[,] newMatrix = new int[m,n];

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            newMatrix[i,j] = new Random().Next(min, max + 1);
        }
    }
    return newMatrix;
}

void ShowTwoDimArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

// Задача №1
// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по возрастанию элементы каждой строки двумерного массива.
/*
void LinesInAscendingOrder(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }

int[,] myArray = CreateRandomTwoDimArray(4,4,1,9);
ShowTwoDimArray(myArray);
Console.WriteLine();
LinesInAscendingOrder(myArray);
ShowTwoDimArray(myArray);
*/

// Задача №2
//Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
/*
int SumLineElements(int[,] array, int i)
{
  int sum = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sum += array[i,j];
  }
  return sum;
}

int[,] myArray = CreateRandomTwoDimArray(4,5,1,9);
ShowTwoDimArray(myArray);
Console.WriteLine();

int minSumLine = 0;
int sum = SumLineElements(myArray, 0);
for (int i = 1; i < myArray.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(myArray, i);
  if (sum > tempSumLine)
  {
    sum = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"The sum of lines {minSumLine+1} is equal to {sum}- this is the minimum");
*/
// Задача №3
//Заполните спирально массив 4 на 4.


