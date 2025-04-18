using Command;
var remote = new Remote();

remote.SetCommand(new LightOnCommand(new Light()));
remote.SendCommand();

remote.SetCommand(new FanOnCommand(new Fan()));
remote.SendCommand();

remote.SetCommand(new LightOffCommand(new Light()));
remote.SendCommand();

remote.SetCommand(new FanOffCommand(new Fan()));
remote.SendCommand();

remote.SendUndoCommand();
remote.SendUndoCommand();
remote.SendUndoCommand();
remote.SendUndoCommand();