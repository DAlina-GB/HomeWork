//Задача №1
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
void NumberCheck(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Your number: {number} - palindrome.");
  }
  else Console.WriteLine($"Your number: {number} - not palindrome.");
}

Console.Write ("Input number: ");
string? number = Console.ReadLine();

NumberCheck(number);
*/

//Задача №2
// Напишите программу, которая принимает
//на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*double FindLength (double xA,double yA,double zA,double xB,double yB,double zB)
{
   return Math.Sqrt(Math.Pow((xB-xA), 2) + Math.Pow((yB-yA), 2) + Math.Pow((zB-zA), 2));
}
double xA=0;
double xB=0;
double yA=0;
double yB=0;
double zA=0;
double zB=0;

Console.Write("Input coordinates xA: ");
xA = Convert.ToDouble(Console.ReadLine());

Console.Write("Input coordinates xB: ");
xB = Convert.ToDouble(Console.ReadLine());

Console.Write("Input coordinates yA: ");
yA = Convert.ToDouble(Console.ReadLine());

Console.Write("Input coordinates yB: ");
yB = Convert.ToDouble(Console.ReadLine());

Console.Write("Input coordinates zA: ");
zA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты zB: ");
zB = Convert.ToDouble(Console.ReadLine());

double result = FindLength (xA, yA, zA, xB, yB,zB);
Console.WriteLine($"Distance in 3D space {result}"); */

//Задача №3
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
 void Cube(int num)
{
  int current = 0;
  while (current <= num)
  { Console.Write ((current*current*current) + " ");
    current++;
  }
}
    Console.Write ("Input integer number: ");
    int num = Convert.ToInt32(Console.ReadLine());

    Cube(num);
*/