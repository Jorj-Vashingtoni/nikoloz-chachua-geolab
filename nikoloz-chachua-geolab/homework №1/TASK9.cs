#if TASK9
Console.WriteLine("please enter your local time, firstly enter hours...");
int hour = int.Parse(Console.ReadLine());
Console.WriteLine("and now enter the minutes....");
int minute = int.Parse(Console.ReadLine());


if(hour >= 0 && hour <= 24 && minute >= 0 && minute <= 59)
{
    if (hour >= 5 && hour <= 11  )
    {
        Console.WriteLine("Good Morning");
    }
    else if (hour > 12 && hour <=16 )
    {
        Console.WriteLine("Good Afternoon");
    }
    else if (hour > 17 && hour <=20)
    {
        Console.WriteLine("Good Evening");
    }
    else 
    {
        Console.WriteLine("Good Night");
    }
}
else
{
    Console.WriteLine("please provide valid data...");
}
#endif