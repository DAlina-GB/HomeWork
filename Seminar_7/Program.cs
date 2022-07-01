//Сгенерировать двух мерный массив и заполнить егослучайными числами в заданном диапазоне.
int[,] CreateRandomTwoDimArray(int a, int b, int min, int max)
{
    int[,] newMatrix = new int[a, b];
    for (int i = 0; i < a; i++)
        for (int j = 0; j < b; j++)
        {
           newMatrix[i, j] = new Random().Next(min, max + 1);
            Console.Write(newMatrix[i, j] + " "); 
        }
    Console.WriteLine();
    return newMatrix;
        
 }
//int[,] array = CreateRandomTwoDemArray(4, 5, 1, 9);

//Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. 
//Выведите полученный массив на экран.
/*int[,] CreateArray(int a, int b)
{
    int[,] newMatrix = new int[a, b];
    for (int i = 0; i < a; i++)
        for (int j = 0; j < b; j++)
            newMatrix[i, j] = i + j;

    return newMatrix;
}
void ShowTwoDimArray(int[,] array);                      //метод для вывода масива на экран 
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(newMatrix[i, j] + " ");
    }
    Console.WriteLine();  
}
*/

//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты.
/*
int[,] UpdateArrayEvenIndexQuad(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)

            if (i % 2 == 0 && j % 2 == 0)
    
                array[i, j] *= array[i, j];
            }
            Console.WriteLine(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}
int[,]myArray = CreateRandomTwoDemArray(4, 5, 1, 9);
Console.WriteLine();
UpdateArrayEvenIndexQuad(myArray); */
/*
int[,] UpdateArrayEvenIndexQuad(int[,] array) //Сокращенная версия этой же задачи
{
    for (int i = 0; i < array.GetLength(0); i+=2)
        for (int j = 0; j < array.GetLength(1); j+=2)
                array[i, j] *= array[i, j];
        
    return array;
}
int[,]myArray = CreateRandomTwoDemArray(4, 5, 1, 9);
Console.WriteLine();
UpdateArrayEvenIndexQuad(myArray); */

//Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
//(с индексами (0,0); (1;1) и т.д.
/*int[,] SumOfDiagonal(int[,] array)
{
    int sum =0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
         for (int j = 0; j < array.GetLength(1); j++)
         {
             if (i==j)
             {
                 sum+=array[i,j];
             }
         }
    }         
    return array;
}
int[,] myArray = CreateRandomTwoDemArray(4, 5, 1, 9);     //Сокращенная версия этой же задачи
Console.WriteLine(SumOfDiagonal(myArray));

int[,] SumOfDiagonal(int[,] array)
{
    int sum =0;
    for (int i = 0; i < array.GetLength(0); i++)
        sum+=array[i,j];
             
    return array;
}
*/