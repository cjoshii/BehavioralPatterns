namespace Command;

public interface ICommand
{
    void Execute();

    void Undo();
}

public class LightOnCommand(Light light) : ICommand
{
    public void Execute()
    {
        light.TurnOn();
    }

    public void Undo()
    {
        light.TurnOff();
    }
}

public class LightOffCommand(Light light) : ICommand
{
    public void Execute()
    {
        light.TurnOff();
    }

    public void Undo()
    {
        light.TurnOn();
    }
}

public class FanOnCommand(Fan fan) : ICommand
{
    public void Execute()
    {
        fan.TurnOn();
    }

    public void Undo()
    {
        fan.TurnOff();
    }
}

public class FanOffCommand(Fan fan) : ICommand
{
    public void Execute()
    {
        fan.TurnOff();
    }

    public void Undo()
    {
        fan.TurnOn();
    }
}
