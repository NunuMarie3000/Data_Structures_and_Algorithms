using LinkedList_Implementation_Solution;

namespace Class07
{
  public class Program
  {
    static void Main(string[] args)
    {
      // DEMO
      OurNode first = new OurNode("First");
      OurNode second = new OurNode("Second");
      OurNode third = new OurNode("Third");
      OurNode fourth = new OurNode("Fourth");
      OurNode fifth = new OurNode("Fifth");

      OurLinkedList CustomLinkedList = new OurLinkedList(new List<OurNode> { first, second, third, fourth, fifth });

      // Console.WriteLine(CustomLinkedList.Head.Info);
      // Console.WriteLine(CustomLinkedList.Head.Next.Info);

      // Console.WriteLine(CustomLinkedList.Tail.Prev.Info);
      OurNode c = CustomLinkedList.Head;

      while(c != null)
      {
        Console.WriteLine(c.Info);
        c = c.Next;
      }
      Console.WriteLine();
      CustomLinkedList.AddFirst(new OurNode("Zero"));
      OurNode d = CustomLinkedList.Tail;

      while(d != null)
      {
        Console.WriteLine(d.Info);
        d = d.Prev;
      }
      Console.WriteLine();
      
    }
  }
}