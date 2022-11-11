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

    // public class LinkedListClass
    // {
    //   internal NodeClass Head { get; set; }

    //   internal NodeClass Tail { get; set; }

    //   public LinkedListClass()
    //   {
    //     Head = new NodeClass();
    //   }
    //   public LinkedListClass(List<NodeClass> NodeClasss)
    //   {
    //     //Add All implementation
    //     Head = NodeClasss.First();
    //     if (NodeClasss.Count() == 1)
    //       Head.Next = null;
    //     else
    //     {
    //       Head.Next = NodeClasss[1];
    //       NodeClass Current = Head.Next;

    //       for (int i = 1; i <= NodeClasss.Count - 1; i++)
    //       {
    //         if (i != NodeClasss.Count - 1)
    //         {
    //           Current.Next = NodeClasss[i + 1];
    //           Current.Prev = NodeClasss[i - 1];
    //         }
    //         else
    //         {
    //           Current.Next = null;
    //           Current.Prev = NodeClasss[i - 1];
    //           break;
    //         }
    //         Current = Current.Next;
    //       }
    //       Tail = Current;
    //     }

    //   }

    //   public void AddFirst(NodeClass node)
    //   {
    //     Head = node;
    //   }

    //   public void AddLast(NodeClass node)
    //   {
    //     // check our head to make sure we have one
    //     // iterate through that chain of next to see if we have any additional NodeClasss
    //     if (Head.Next == null)
    //     {
    //       Head.Next = node;
    //     }
    //     else
    //     {
    //       NodeClass Current = Head.Next;
    //       // iterate through what we have
    //       while (Head.Next != null)
    //       {
    //         Console.WriteLine(node.Next);
    //       }
    //     }
    //   }
    // }

    // public class NodeClass
    // {
    //   public string Info { get; set; }
    //   public NodeClass Next { get; set; }
    //   public NodeClass Prev { get; set; }
    //   public NodeClass()
    //   {
    //     Info = "";
    //     Next = null;
    //     Prev = null;
    //   }
    //   public NodeClass(string info)
    //   {
    //     Info = info;
    //     Next = null;
    //     Prev = null;
    //   }
    //   public NodeClass(string info, NodeClass next)
    //   {
    //     Info = info;
    //     Next = next;
    //     Prev = null;
    //   }
    // }
  }
}