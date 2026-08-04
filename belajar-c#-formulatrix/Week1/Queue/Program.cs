using System.Collections;


QueueManager queueManager = new QueueManager();

queueManager.AddTask("Queued A"); // entering new queue
queueManager.AddTask("Queued B");
queueManager.ProcessNextTask(); // remove queue FIFO (First in FIrstOut)
queueManager.ProcessNextTask();
queueManager.ProcessNextTask(); // empty queue



public class QueueManager {
// readonly for thread safety called variable _tasQueue
// _taskQueue is a private variable that can only be accssed local class
private readonly Queue<string> _taskQueue = new Queue<string>(); 

public void AddTask(string taskName)
    {
        _taskQueue.Enqueue(taskName);
        Console.WriteLine(taskName);
    }
public void ProcessNextTask()
    {
        if (_taskQueue.Count == 0)
        {
            Console.WriteLine("Queue is empty");
            return ;
        }
        string activeTask = _taskQueue.Dequeue();
        Console.WriteLine($"proccesed {activeTask}");
    }

}
