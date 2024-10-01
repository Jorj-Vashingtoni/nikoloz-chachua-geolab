namespace nikoloz_chachua_geolab.homework__2;

public class TASK2
{
    public static void Run()
    {
        int i = 0;
        int j = 1;
        while (j <= 50)
        {
            i += j;
            j++;
        }
        Console.WriteLine(i);
        
        int n = 0;
        int sum = 0;
        while (n < 5)
        {
            Console.WriteLine("enter 5");

            int a=int.Parse(Console.ReadLine());

            sum += a;

            n++;
        }
        Console.WriteLine(sum);
    }
}