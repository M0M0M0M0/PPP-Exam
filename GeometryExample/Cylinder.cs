namespace PPC_Exam;

public class Cylinder
{
    public double Radius { get; set; }
    public double Height { get; set; }

    private double baseArea;
    private double lateralArea;
    private double totalArea;
    private double volume;
    
    public void Process()
    {
        baseArea = Radius * Radius * Math.PI;
        lateralArea = 2 * Math.PI * Radius * Height;
        totalArea = 2 * Math.PI * Radius * (Height + Radius);
        volume = Math.PI * Radius * Radius * Height;
    }
    
    public string Result()
    {
        return "Radius: " +  Radius + ", Height: " + Height + "\n"
               +"Base Area: " + baseArea.ToString("F2") + " | "
               + "Lateral Area: " + lateralArea.ToString("F2") + " | "
               + "Total Area: " + totalArea.ToString("F2") + " | "
               + "Volume: " + volume.ToString("F2");
    }
}