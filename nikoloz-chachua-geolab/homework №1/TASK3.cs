#if TASK3
Console.WriteLine("please provide  your grade...");

int num = int.Parse(Console.ReadLine());

if (num > 0 && num < 100)
{

    if (num <= 59)
    {
        Console.WriteLine("unfortunately you have failed this class, your mark is - 'F' ");
    }
    else if (num >= 60 && num <= 69)
    {
        Console.WriteLine("you have passed the class, your mark is - D ");
    }
    else if (num >= 70 && num <= 79)
    {
        Console.WriteLine("you have passed the class, your mark is - C ");
    }
    else if (num >= 80 && num <= 89)
    {
        Console.WriteLine("you have passed the class, your mark is - B ");
    }
    else if (num >= 90 && num <= 100)
    {
        Console.WriteLine("you have passed the class, your mark is - A ");
    }
}
else
{
    Console.WriteLine("please provide with valid grade...");
}
#endif