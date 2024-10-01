namespace nikoloz_chachua_geolab.homework__2;

public class AVERAGE
{
    public static void Run()
    {
        double grade=0;
        int index=0;
        string confirmation;
        double avg=0;
        do
        {

            Console.WriteLine("enter your grades");

            int mark = int.Parse(Console.ReadLine());
            if( mark >= 0 && mark <=100)
            {
                index++;
                grade += mark;
            }
            else
            {
                Console.WriteLine("enter valid mark from 0 to 100");
            }
            avg = grade / index;
            Console.WriteLine("if you woul like to continie press yes...");
            confirmation = Console.ReadLine();


        }
        while (confirmation == "yes");
        Console.WriteLine($"here is your avarage score: {avg}");
    }
}