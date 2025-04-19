namespace Command;
public class Fan
{
    public void TurnOn() => Console.WriteLine($"Turning fan on");
    public void TurnOff() => Console.WriteLine($"Turning fan off");
}

public class Light
{
    public void TurnOn() => Console.WriteLine($"Turning light on");
    public void TurnOff() => Console.WriteLine($"Turning light off");
}