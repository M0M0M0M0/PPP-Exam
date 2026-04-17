namespace Inheritance;

public class Tiger : Animal
{
    public Tiger(int weight, string name)
    {
        SetMe(weight, name);
    }
    public override void Show()
    {
        base.Show();
    }
}