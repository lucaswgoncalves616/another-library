namespace Library;

class Program
{
    static void Main(string[] args)
    {
        List<User> students = new List<User>();
        List<User> teachers = new List<User>();

        teachers.Add(new Teacher("Patrícia Santos", "patricia.santos@escola.edu"));
        teachers.Add(new Teacher("Roberto Lima", "roberto.lima@escola.edu"));
        teachers.Add(new Teacher("Adriana Melo", "adriana.melo@escola.edu"));
        
        students.Add(new Student("Maria Silva", "maria.silva@hotmail.com"));
        students.Add(new Student("Pedro Alves", "pedro.alves@hotmail.com"));
        students.Add(new Student("Ana Costa", "ana.costa@hotmail.com"));
        
        Library.NewLoan(Library.Books[3].BookId, students[0].Id, "12-jan", "15-fev");
        Library.NewLoan(Library.Books[2].BookId, students[1].Id, "13-fev", "16-mar");
        Library.NewLoan(Library.Books[0].BookId, students[2].Id, "14-mar", "17-abr");
        
        LoanRelation.ShowAllLoans();
        

        //Console.ReadKey();
    }
}
