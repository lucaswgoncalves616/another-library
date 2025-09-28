namespace Library;

public class Student : User
{
    public override int getLoansLimit()
    {
        return 2;
    }
}