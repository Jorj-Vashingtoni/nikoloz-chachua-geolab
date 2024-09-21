#if TASK4
Console.WriteLine("Enter the year you doubt is not a leap year");
int year = int.Parse(Console.ReadLine());

    if (year % 4 == 0 && year % 100 == 0 && year % 400 == 0)
    {
        Console.WriteLine($"the {year} is a leap year");
    }
    else if (year % 4 == 0 && year % 100 != 0)
    {
        Console.WriteLine($"the {year} is a leap year");
    }
    else
    {
        Console.WriteLine($"the {year} is not a leap year");
    }

    #endif