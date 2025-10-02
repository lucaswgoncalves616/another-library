namespace Library;

public class Teacher : User
{
    public Teacher(string name, string email) : base(name, email)
    {
        
    }

    public override int getLoansLimit()
    {
        return 5;
    }
}