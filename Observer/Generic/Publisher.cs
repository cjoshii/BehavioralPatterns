namespace Observer.Generic;

public class Publisher
{
    public Manager Manager;

    public Publisher()
    {
        this.Manager = new Manager();
    }

    public void SomethingHappens(string type, string data)
    {
        Manager.Notify(type, data);
    }
}