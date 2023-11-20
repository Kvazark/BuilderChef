namespace BuilderPattern;

public class SousChef: Builder
{
    public SousChef()
    {
        chef = new Chef("SousChef");
    }
    public override void BuildName()
    {
        chef["name"] = "Jiny Fiterly";
    }

    public override void BuildGender()
    {
        chef["gender"] = "woman";
    }

    public override void BuildSpecialization()
    {
        chef["specialization"] = "Fish Chef";
    }

    public override void BuildExperience()
    {
        chef["experience"] = "2";
    }
}