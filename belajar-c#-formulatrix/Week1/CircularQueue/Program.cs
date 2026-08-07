

CircularQueue circularQueue = new();
circularQueue.Log(1);
circularQueue.Log(2);
circularQueue.Log(3);
circularQueue.Log(4);
circularQueue.Read();



public class CircularQueue
{
    private readonly List<int> _queue = new();
    private readonly int _maxCapacity = 3;

    static protected void Print(string message)
    {
        Console.WriteLine(message);
    }

    public void Log(int number)
    {
        if (_queue.Count == _maxCapacity)
        {
            Print("Buffer full");
            return;
        }
        _queue.Add(number);
        Print($"Logged {number}");
    }
    public void Read()
    {
        if (_queue.Count == 0)
        {
            Console.WriteLine("Queuer is Empty");
        }

        Print($"Read {_queue[0]}");
        _queue.RemoveAt(0);
    }

}
