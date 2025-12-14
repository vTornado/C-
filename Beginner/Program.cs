// See https://aka.ms/new-console-template for more information
/*
Console.Write("Whats your name? ");
string name = Console.ReadLine();
Console.Write("How tall are you? ");
int height = Convert.ToInt32(Console.ReadLine());
Console.Write("How old are you? ");
int age = Convert.ToInt32(Console.ReadLine());
if (age <30 || height >170)
{
    Console.WriteLine("Eligible for discount");
}
else 
{
    Console.WriteLine("No discount");
}
*/



using System.Numerics;

Console.Write("Enter a binary number: ");
String Iteration = Console.ReadLine();
int loop = Iteration.Length-1;
double total = 0D;
int power = 0;
while (loop >= 0)
{
    int x = int.Parse(Iteration[loop].ToString());
    total = x * Math.Pow(2D,Convert.ToDouble(power)) + total;
    power++;
    loop--;
}
Console.WriteLine(total);