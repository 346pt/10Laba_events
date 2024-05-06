using System.CodeDom.Compiler;

public class Event
{
    public delegate void EventHandler(string text);
    public event EventHandler EventCreator;
    public string Name { get; set; }
    public void EventGenerator()
    {
        if (EventCreator != null)
        {
            EventCreator(Name);
        }
    }
}