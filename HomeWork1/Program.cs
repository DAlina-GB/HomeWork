﻿/*int num1, num2;
Console.Write ("Input first integer number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input second integer number: ");
num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)

{
	Console.WriteLine ("max " + num1 );
}
 else
{  
	Console.WriteLine ("max " + num2 );
}
*/
 int num1, num2, num3; 

Console.Write("Input first integer number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third integer number: ");
num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

If(num1 > max) max = num1;
If(num2 > max) max = num2;
If(num3 > max) max = num3;

Console.Write("max = ");
Console.WriteLine(max);