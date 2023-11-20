using BuilderPattern;

public class Program
{
    private static void Main(string[] args)
    {
        Builder builder;
        Restaurant restaurant = new Restaurant();
        builder = new SeniorChef();
        restaurant.Construct(builder);
        builder.Chef.ShowChefs();
        
        builder = new SousChef();
        restaurant.Construct(builder);
        builder.Chef.ShowChefs();
    }
}