//Задайте значения M и N. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N.
/*
void SumOfElements(int m, int n, int sum)
{
  sum = sum + n;
  if (n <= m)
  {
    Console.Write($"Sum of elements= {sum} ");
    return;
  }
  SumOfElements(m, n - 1, sum);
}

Console.Write ("Input first integer number: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write ("Input second integer number: ");
int n = Convert.ToInt32(Console.ReadLine());
int temp = m;
if (m > n) 
{
  m = n; 
  n = temp;
}
SumOfElements(m, n, temp=0);
*/

//Напишите программу, которая будет принимать на вход число и возвращать кол-во его цифр.
/*

int NumberOfDigits(int num)
{
    if (num / 10 == 0) return 1;
    return 1 + NumberOfDigits(num /= 10) ;  
}
Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Number of digits {NumberOfDigits(num)}");
*/
