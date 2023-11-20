namespace BuilderPattern;

public class Chef
{
    private string _chefType;

    private Dictionary<string, string> _parts =
        new Dictionary<string, string>();

    public Chef(string chefType)
    {
        this._chefType = chefType;
    }
    public string this[string key]
    {
        get { return _parts[key]; }
        set { _parts[key] = value; }
    }
    public void ShowChefs()
    {
        Console.WriteLine("\n");
        Console.WriteLine("Chef Type: {0}", _chefType);
        Console.WriteLine(" Name : {0}", _parts["name"]);
        Console.WriteLine(" Gender : {0}", _parts["gender"]);
        Console.WriteLine(" Specialization: {0}", _parts["specialization"]);
        Console.WriteLine(" Experience : {0}", _parts["experience"]);
    }
}