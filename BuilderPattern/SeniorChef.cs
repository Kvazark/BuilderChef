namespace BuilderPattern;

public class SeniorChef : Builder
{
    public SeniorChef()
    {
        chef = new Chef("SeniorChef");
    }
    public override void BuildName()
    {
        chef["name"] = "Lui Soll";
    }

    public override void BuildGender()
    {
        chef["gender"] = "man";
    }

    public override void BuildSpecialization()
    {
        chef["specialization"] = "Patissier";
    }

    public override void BuildExperience()
    {
        chef["experience"] = "5";
    }
}