namespace Observer.Generic;

public class Manager
{
    private IDictionary<string, IList<IListner>> listenerMap;

    public Manager()
    {
        listenerMap = new Dictionary<string, IList<IListner>>();
    }

    public void Subscribe(string type, IListner listner)
    {
        if (!listenerMap.ContainsKey(type))
        {
            listenerMap[type] = new List<IListner>();
        }
        listenerMap[type].Add(listner);
    }

    public void Notify(string type, string data)
    {
        if (!listenerMap.ContainsKey(type))
            return;
        foreach (var listner in listenerMap[type])
            listner.Notify(data);
    }
}