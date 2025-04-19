namespace Observer.EH;

public class Subscriber
{
    public void HanldeEvent(Object? sender, EventArgs args)
    {
        Console.WriteLine($"Notification received for event");
    }
}