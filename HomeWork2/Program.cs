// Задача №1
// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

/*
int IsolateTen (int num)
{
   int sot = num / 10;
   int res = sot % 10;
   return res;
}
     
Console.Write ("Input three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = IsolateTen(num);
Console.WriteLine ($"Remainder of the number is {result}");
*/

// Задача №2
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*int IsolateThree(int num)
{
if(num >= 100 && num <= 999)
{
    int des = num % 10;
    int res = des;
    return res;
}
else 
{
    return -1;
}
}
Console.Write ("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = IsolateThree(num);

if (result==-1)
{
    Console.WriteLine("Your number in not three-digits");
}
else
{
    Console.WriteLine ($"Remainder of the number is {result}");
}
*/
//Задача № 3
//Напишите программу, 
//которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void dayWeek (int num) 
{
  if (num == 6 || num== 7) 
  {
  Console.WriteLine("Yes,Weekend");
  }
  else if (num < 1 || num > 7) 
  {
    Console.WriteLine("Error");
  }
  else Console.WriteLine("No,it's a weekday");
}

Console.Write("Input the number of the day of the week: ");
int num = Convert.ToInt32(Console.ReadLine());

dayWeek (num);
