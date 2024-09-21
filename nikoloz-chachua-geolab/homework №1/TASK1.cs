#if TASK1
Console.WriteLine("please provide with an integer...");
int num = int.Parse(Console.ReadLine());

if (num == 0)
{
    Console.WriteLine($"the given number --- {num} --- equals to 0");
}
else if (num > 0)
{
    Console.WriteLine($"the given number --- {num} --- is positive");
}
else if(num < 0)
{
    Console.WriteLine($"the given number --- {num} --- is negative");
}
#endif