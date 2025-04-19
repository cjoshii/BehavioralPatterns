namespace Observer.EH;

public class Publisher
{
    public event EventHandler? OnEvent;

    public void DoSomethingThatTriggersEvent()
    {
        OnEvent?.Invoke(this, new EventArgs());
    }
}