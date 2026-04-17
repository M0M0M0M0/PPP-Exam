namespace Inheritance;

public class Lion : Animal
{
    public Lion(int weight, string name)
    {
        SetMe(weight, name);
    }
    public override void Show()
    {
        base.Show();
    }
}