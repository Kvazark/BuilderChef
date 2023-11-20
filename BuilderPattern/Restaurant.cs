namespace BuilderPattern;

public class Restaurant
{
    public void Construct(Builder builder)
    {
        builder.BuildName();
        builder.BuildGender();
        builder.BuildSpecialization();
        builder.BuildExperience();
    }
}