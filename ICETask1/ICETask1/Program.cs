using ICETask1;

class Program
{
    static void Main(string[] args)
    {
        Course course = new Course();

        course.Grade = 75;

        Console.WriteLine("Grade: " + course.Grade);
        Console.WriteLine("Passed: " + course.IsPass);
    }
}
