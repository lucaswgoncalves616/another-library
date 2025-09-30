namespace Library;

public abstract class User
{
    public int Id { get; set; }
    private static int nextId = 1;

    public static int NextId
    {
        get => nextId;
        set => nextId = value;
    }

    public String Name { get; set; }
    public String Email { get; set; }

    protected User(string name, string email)
    {
        Id = NextId++;
        Name = name;
        Email = email;
    }

    public abstract int getLoansLimit();

    public override string ToString()
    {
        return $"ID: {Id}" +
               $"\nNome: {Name}" +
               $"\nEmail: {Email}\n";
    }
}