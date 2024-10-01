namespace nikoloz_chachua_geolab.homework__2;

public class TRANSACTIONS
{
    public static void Run()
    {
        decimal bal=0;
decimal deposit=0;
decimal withdraw=0;
decimal overdraft = 0;

string confirmation;
string option;
string permission;

do
{
    Console.WriteLine("please enter the type of operation (withdraw or deposit)");
    option = Console.ReadLine();
    if (option == "deposit")
    {
        Console.WriteLine($"current balance:{bal}");
        Console.WriteLine("you have chosen to deposit, now enter the amount you would like to add to the balance");
        decimal dep = decimal.Parse(Console.ReadLine());
        bal += dep;
        deposit += dep;
        Console.WriteLine($"your new balance is:{bal}, would you like to proceed with more operations?");
    }
    else if (option == "withdraw")
    {
        Console.WriteLine($"current balance:{bal}");
        Console.WriteLine("you have chosen to withdraw funds from account, please provide with amount...");
        decimal with = Convert.ToDecimal(Console.ReadLine());
        if (bal >= with)
        {
            Console.WriteLine($"current balance:{bal}");
            bal -= with;
            withdraw += with;
            Console.WriteLine($"the new balance is: {bal}");
        }
        else
        {
            Console.WriteLine($"current balance:{bal}");
            Console.WriteLine("would you like to go overdraft? (if yes press yes)");
            permission = Console.ReadLine();
            if (permission == "yes")
            {
                bal -= with;
                withdraw += with;
                decimal overd;
                overdraft = -bal;
                Console.WriteLine($"you have gone overdraft by {overdraft}");
                Console.WriteLine("would you like to continiue with operations?");
            }
        }
    }
    else if (option != "withdraw" && option != "deposit")
    {
        Console.WriteLine("invlaid operation...");
        Console.WriteLine("enter yes to continiue...");

    }
    
    confirmation = Console.ReadLine();

}
while (confirmation == "yes");
if (bal >= 0)
{
    Console.WriteLine($"here is your balance: {bal}");
}
else if (bal < 0)
{
    Console.WriteLine($"here is your balance: {overdraft}");

}
Console.WriteLine($"here is how much you have deposited: {deposit}");
Console.WriteLine($"here is how much you have withdrawed: {withdraw}");
Console.WriteLine($"here is how much you have overdrawn: {overdraft}");
    }
}