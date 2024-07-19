// See https://aka.ms/new-console-template for more information
Console.WriteLine("what are you doing ? ");
string doing = Console.ReadLine();
Console.WriteLine("what are you drinking ? ");
string drink = Console.ReadLine();
Console.WriteLine("do you love coding or networking ? ");
string love = Console.ReadLine();
if (love == "coding")
{
    Console.WriteLine($"""
I'm a programmer 
I write code
I don't fix computers
""");
}
else if (love == "networking")
{
    Console.WriteLine("5G");
}
else
{
    Console.WriteLine("error");
}
int brain = int.Parse(Console.ReadLine());
if (brain == 0)
{
    Console.WriteLine("order Coffee()");
}
else
{
    Console.WriteLine("keep Coding()");
}
Console.ReadLine();