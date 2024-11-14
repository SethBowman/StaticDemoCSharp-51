namespace StaticDemoCSharp_51;

class Program
{
    static void Main(string[] args)
    {
        //static class/static method
        Console.WriteLine("Hello, World!");

        var result = MathHelper.Add(2, 2);

        //Console.WriteLine(result);
        
        //Greet();

        var cs51 = new Classroom();
        var cs52 = new Classroom();

        Classroom.Subject = "C#";
    }

    public static void Greet()
    {
        Console.WriteLine("Hello");
    }
}
