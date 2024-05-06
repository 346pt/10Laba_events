using System.Threading.Channels;

public class EventText
{
    public void EventProcessing(string text)
    {
    Console.WriteLine($"Событие сгенерировано с помощью {text}" );
    }
}