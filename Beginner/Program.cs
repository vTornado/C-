// See https://aka.ms/new-console-template for more information

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