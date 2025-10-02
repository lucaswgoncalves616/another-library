namespace Library;

public class Teacher : User
{
    public Teacher(string name, string email) : base(name, email)
    {
        
    }

    private int loanLimit = 5;
    public int LoanLimit {get => loanLimit;}
    
    public override int getLoansLimit()
    {
        return loanLimit;
    }
}