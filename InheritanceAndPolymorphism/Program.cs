using Inheritance;

public class Program
{
    static void Main(string[] args)
    {
        Tiger tiger = new Tiger(100, "tiger");
        tiger.Show();

        Lion lion = new Lion(200, "lion");
        lion.Show();
    }
}