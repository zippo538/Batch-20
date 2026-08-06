
LinkedList linkedList = new LinkedList();

linkedList.Appended(5);
linkedList.Appended(10);
linkedList.Sequence();


public class LinkedList 
{
    List<int> linkedList = new List<int>();

    private void Print(string message)
    {
        Console.WriteLine(message);
    }

    public void Appended(int number)
    {
        linkedList.Add(number);
        Print($"Appended : {number}");
        
    }
    public void Sequence()
    {
        if (linkedList.Count == 0)
        {
            Print("Not have Sequence in list");
        }
        string result = string.Join(" -> ", linkedList);
        Print($"Sequence : {result}");
    }

}