using Singleton;

public class Program
{
    private static void Main(string[] args)
    {
        MainChef chef1 = MainChef.GetMainChef();
        MainChef chef2 = MainChef.GetMainChef();
        MainChef chef3 = MainChef.GetMainChef();
        MainChef chef4 = MainChef.GetMainChef();

        if (chef1 == chef2 && chef2 == chef3 && chef3 == chef4)
        {
            Console.WriteLine("Same instance\n");
        }
        chef1.PrepareDish("Lasagna");
        chef2.PrepareDish("Roast goose"); 
        chef3.PrepareDish("Sirloin steak "); 
        chef4.PrepareDish("Goulash"); 
    }
}