namespace Library;

public abstract class User
{
    public int Id { get; set; }
    public String Name { get; set; }
    public String Email { get; set; }

    public abstract int getLoansLimit();

}