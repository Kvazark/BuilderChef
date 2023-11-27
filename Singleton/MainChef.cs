namespace Singleton;

public class MainChef
{
    static MainChef instance;

    protected MainChef()
    {
        
    }

    public static MainChef GetMainChef()
    {
        if (instance == null)
        {
            instance = new MainChef();
        }
        return instance;
    }
    public void PrepareDish(string dishName)
    {
        Console.WriteLine("Chef is preparing dish: " + dishName);
    }

}