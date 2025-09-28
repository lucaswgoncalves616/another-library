namespace Library;

public class Student : User
{
    public Student(string name, string email) : base(name, email)
    {
        
    }

    public override int getLoansLimit()
    {
        return 2;
    }
}