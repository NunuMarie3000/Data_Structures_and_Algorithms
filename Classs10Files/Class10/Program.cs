using Class10.Classes;

namespace Class10
{
  public class Program
  {
    static void Main(string[] args)
    {
      AQueue myQueue = new AQueue();
      Console.WriteLine(myQueue.IsEmpty());
      myQueue.Enqueue(new ANode("First"));
      myQueue.Enqueue(new ANode("Second"));
      myQueue.Enqueue(new ANode("Third"));
      myQueue.Enqueue(new ANode("Fourth"));
      myQueue.Enqueue(new ANode("Fifth"));
      Console.WriteLine(myQueue.IsEmpty());
      Console.WriteLine();

      Console.WriteLine(myQueue.Front.Value);
      Console.WriteLine(myQueue.Front.Next.Value);
      Console.WriteLine();
      // Console.WriteLine(myQueue.Peek().Value);
      // myQueue.Dequeue();
      // Console.WriteLine();
      // Console.WriteLine(myQueue.Peek().Value);
      // Console.WriteLine(myQueue.Top.Next.Value);
      // myQueue.Dequeue();
      // Console.WriteLine();
      // Console.WriteLine(myQueue.Peek().Value);
      // Console.WriteLine(myQueue.Top.Value);
      // Console.WriteLine(myQueue.Top.Next.Value);



      // AStack myStack = new AStack();
      // Console.WriteLine(myStack.IsEmpty());
      // myStack.Push(new ANode("First"));
      // myStack.Push(new ANode("Second"));
      // myStack.Push(new ANode("Third"));
      // myStack.Push(new ANode("Fourth"));
      // myStack.Push(new ANode("Fifth"));
      // Console.WriteLine(myStack.IsEmpty());
      // Console.WriteLine(myStack.Top.Value);
      // Console.WriteLine(myStack.Top.Next.Value);
      // Console.WriteLine();
      // Console.WriteLine(myStack.Peek().Value);
      // myStack.Pop();
      // Console.WriteLine();
      // Console.WriteLine(myStack.Peek().Value);
      // Console.WriteLine(myStack.Top.Next.Value);
      // myStack.Pop();
      // Console.WriteLine();
      // Console.WriteLine(myStack.Peek().Value);
      // Console.WriteLine(myStack.Top.Value);
      // Console.WriteLine(myStack.Top.Next.Value);

    }
  }
}

