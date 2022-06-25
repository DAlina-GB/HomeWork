//Задача №1
//Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)    2, 4 -> 16
/*
int Exponentiation(int num1, int num2)
{
  int result = 1;
  for(int i=1; i <= num2; i++)
  {
    result *= num1;
  }

    return result;
}

  Console.Write ("Input number A: ");
  int num1 = Convert.ToInt32(Console.ReadLine());
  Console.Write ("Input number B: ");
  int num2 = Convert.ToInt32(Console.ReadLine());

  int res = Exponentiation (num1,num2);
  Console.WriteLine($"Answer: {res}");
*/

//Задача №2
//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19, 3, 44, 3 -> [1, 2, 5, 7, 19, 3, 44, 3
/*
int[] num = new int[8];

void RandomArray (int[] array)
{                                       
for (int i = 0; i < array.Length; i = i + 1) 
{                                             
    array[i] = new Random().Next(0,99);          
} 
}   

void WriteArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{                                                    
    Console.Write (array[i]+" ");
} 
 Console.WriteLine();
}

RandomArray (num);
WriteArray (num);
Console.WriteLine();
*/