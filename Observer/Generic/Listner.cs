
namespace Observer.Generic;

public interface IListner
{
    void Notify(string data);
}

public class Listener : IListner
{
    public Listener()
    {

    }

    public void Notify(string data)
    {
        Console.WriteLine($"Notification received: {data}");
    }
}