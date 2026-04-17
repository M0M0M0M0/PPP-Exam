using PPC_Exam;

class Program
{
    static void Main(string[] args)
    {
        Cylinder c = new Cylinder();
        Console.WriteLine("Enter the dimensions of the cylinder");
        Console.Write("Radius: ");
        c.Radius = double.Parse(Console.ReadLine());

        Console.Write("Height: ");
        c.Height = double.Parse(Console.ReadLine());

        c.Process();
        Console.WriteLine("Cylinder Characteristics");
        Console.WriteLine(c.Result());

        Console.ReadLine();
    }
}