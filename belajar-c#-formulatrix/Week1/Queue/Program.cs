using System.Collections;


QueueManager queueManager = new QueueManager();

queueManager.AddTask("Queued A");
queueManager.AddTask("Queued B");
queueManager.ProcessNextTask();
queueManager.ProcessNextTask();


public class QueueManager {
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
