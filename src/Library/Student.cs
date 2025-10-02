namespace Library;

public class Student : User
{
    public Student(string name, string email) : base(name, email)
    {
        
    }

    private int loanLimit = 2;
    public int LoanLimit {get => loanLimit;}
    
    public override int getLoansLimit()
    {
        return loanLimit;
    }
}