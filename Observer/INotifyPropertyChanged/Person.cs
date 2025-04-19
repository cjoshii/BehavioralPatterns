namespace Observer.INPC;
using System.ComponentModel;
using System.Runtime.CompilerServices;

public class Person : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    private string firstName;
    private string lastName;

    public Person(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public string FirstName
    {
        get => firstName;
        set
        {
            if (firstName != value)
            {
                firstName = value;
                Notify();
            }
        }
    }
    public string LastName
    {
        get => lastName;
        set
        {
            if (lastName != value)
            {
                lastName = value;
                Notify();
            }
        }
    }

    private void Notify([CallerMemberName] string? name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}

