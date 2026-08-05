// See https://aka.ms/new-console-template for more information


Stack stack = new Stack();

stack.Push("foo");
stack.Push("bar");
stack.Undo();
stack.Undo();

// check stack count
Console.WriteLine(stack.Count());

stack.Undo(); // should print "Stack is empty"

class Stack : List<string>
{
    List<string> strings = new List<string>(); // create list of strings dynamics

    public void Push(string str) // add string to the list
    {
        strings.Add(str);
        Console.WriteLine($"Type {str}");
    }
    public void Undo() // remove last string from the list 
    {
        if (strings.Count == 0)
        {
            Console.WriteLine("Stack is empty");
            return;
        }
        else
        {
            Console.WriteLine($"Undid {strings[strings.Count -1]}");
            strings.RemoveAt(strings.Count - 1);
        }
    }


}
