﻿using Command;
using Observer.Generic;
using Observer.EH;
using Observer.INPC;
using Strategy;

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


// Observer pattern
var publisher = new Observer.Generic.Publisher();
publisher.Manager.Subscribe("something", new Listener());
publisher.Manager.Subscribe("something", new Listener());
publisher.Manager.Subscribe("something_else", new Listener());
//publisher.SomethingHappens("something", "SomethingData");
//publisher.SomethingHappens("something_else", "SomethingElseData");

var subscriber = new Subscriber();
var publisherEh = new Observer.EH.Publisher();
publisherEh.OnEvent += subscriber.HanldeEvent;

publisherEh.DoSomethingThatTriggersEvent();

var person = new Person("Chintan", "Joshi");

// Manual subscription
person.PropertyChanged += (sender, e) =>
{
    Console.WriteLine($"Property {e.PropertyName} changed!.");
};

person.FirstName = "Krupa";
person.LastName = "Jani";
person.FirstName = "Reya";
person.LastName = "Joshi";

var calculator = new Calculator();
calculator.SetStrategy(new Add());
Console.WriteLine($"Add 2 and 2 : {calculator.Execute(2, 2)}");

calculator.SetStrategy(new Substract());
Console.WriteLine($"Substract 2 from 2 : {calculator.Execute(2, 2)}");

calculator.SetStrategy(new Multiply());
Console.WriteLine($"Multiply 2 into 2 : {calculator.Execute(2, 2)}");