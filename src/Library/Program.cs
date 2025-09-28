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
        
        
        
        /*foreach (User student in students)
        {
            Console.WriteLine(student);
        }
        Console.WriteLine();

        foreach (Book book in books)
        {
            Console.WriteLine(book);
        }*/

        Console.ReadKey();
    }
}
