//Задача №1
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
int[] arr = {1,4,2,1,2};
void PrintArray (int[] array)
{
    int count = array.Length;
    for (int i =0; i<count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
void SeLectionSoft(int[] array)
{
    for (int i=0; i < array.Length-1; i++)
    
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition]=temporary;

 }

PrintArray(arr);
SeLectionSoft(arr);

PrintArray(arr);

//Задача №2
// Напишите программу, которая принимает
//на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//Задача №3
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.