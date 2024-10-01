#if TASK12

Console.WriteLine("plaese enter your age...");
int age = int.Parse(Console.ReadLine());
Console.WriteLine("please provide your yearly income");
int income = int.Parse(Console.ReadLine());

if (age >= 18 && age <= 122 && income >= 25000)
{
    Console.WriteLine("you are allowed to take the loan...");
}
else if (age >= 18 && age <= 122 && income < 25000)
{
    Console.WriteLine("if you would like a guarantee type yes...");
    string access = Console.ReadLine();
    if (access == "yes")
    {
        Console.WriteLine("your income is not enough for loan, please enter the guarantees yearly income");
        int guarantee = int.Parse(Console.ReadLine());
        if (guarantee >= 25000)
        {
            Console.WriteLine("you are allowed to take the loan");
        }
        else
        {
            Console.WriteLine("unfortunately your loan request has been dismissed...");
        }
    }
    else
    {
        Console.WriteLine("not allowed to take the loan...");
    }

}
else if (age < 0 && age > 122)
{
    Console.WriteLine("please enter valid data...");
}
else
{
    Console.WriteLine("you are not allowed to take the loan");
}

#endif