using System.Runtime.InteropServices;

namespace Command;

public class Remote
{
    private Stack<ICommand> history;
    private ICommand? command;

    public Remote()
    {
        history = new Stack<ICommand>();
    }

    public void SetCommand(ICommand command)
    {
        this.command = command;
    }

    public void SendCommand()
    {
        if (command != null)
        {
            command.Execute();
            history.Push(command);
        }
    }

    public void SendUndoCommand()
    {
        if (history.Any())
            history.Pop().Undo();
    }

}


