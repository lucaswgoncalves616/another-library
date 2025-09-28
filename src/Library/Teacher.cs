namespace Library;

public class Teacher : User
{
    public override int getLoansLimit()
    {
        return 5;
    }
}