using System;
using System.Collections;
using System.Collections.Generic;

namespace Class05
{
  public class Program
  {
    static void Main(string[] args)
    {
      LinkedListClass myLinkedList = new LinkedListClass();

      // myLinkedList.Insert(new NodeClass(10));
      // myLinkedList.Insert(new NodeClass(20));
      // myLinkedList.Insert(new NodeClass(30));
      // myLinkedList.Insert(new NodeClass(40));
      // myLinkedList.Insert(new NodeClass(50));
      // myLinkedList.Insert(new NodeClass(60));

      // Console.WriteLine(myLinkedList.ToString());
      // Console.WriteLine(myLinkedList.Includes(30));


      // NOTE: DJ'S DEMO
      NodeClass first = new NodeClass("First");
      NodeClass second = new NodeClass("Second");
      NodeClass third = new NodeClass("Third");
      NodeClass fourth = new NodeClass("Fourth");
      NodeClass fifth = new NodeClass("Fifth");

      List<NodeClass> nodeList = new List<NodeClass> { first, second, third, fourth, fifth };

      LinkedListClass CustomLinkedList = new LinkedListClass(nodeList);

      // Console.WriteLine(CustomLinkedList.Head.Info);
      // Console.WriteLine(CustomLinkedList.Head.Next.Info);

      // Console.WriteLine(CustomLinkedList.Tail.Prev.Info);
      NodeClass c = CustomLinkedList.Head;

      while(c != null)
      {
        Console.WriteLine(c.Info);
        c = c.Next;
      }

      NodeClass d = CustomLinkedList.Tail;

      while(d != null)
      {
        Console.WriteLine(d.Info);
        d = d.Prev;
      }
    }


    // TAKE TWO
    public class LinkedListClass
  {
    internal NodeClass Head { get; set; }

    internal NodeClass Tail { get; set; }

    public LinkedListClass()
    {
      Head = new NodeClass();
    }
    public LinkedListClass(List<NodeClass> NodeClasss)
    {
      //Add All implementation
      Head = NodeClasss.First();
      if (NodeClasss.Count() == 1)
        Head.Next = null;
      else
      {
        Head.Next = NodeClasss[1];
        NodeClass Current = Head.Next;

        for(int i = 1; i <= NodeClasss.Count -1; i++)
        {
          if(i != NodeClasss.Count - 1)
          {
            Current.Next = NodeClasss[i + 1];
            Current.Prev = NodeClasss[i - 1];
          }
          else
          {
            Current.Next = null;
            Current.Prev = NodeClasss[i - 1];
            break;
          }
          Current = Current.Next;
        }
        Tail = Current;
      }

    }

    public void AddFirst(NodeClass node)
    {
      Head = node;
    }

    public void AddLast(NodeClass node)
    {
      // check our head to make sure we have one
      // iterate through that chain of next to see if we have any additional NodeClasss
      if (Head.Next == null)
      {
        Head.Next = node;
      }
      else
      {
        NodeClass Current = Head.Next;
        // iterate through what we have
        while (Head.Next != null)
        {
          Console.WriteLine(node.Next);
        }
      }
    }
  }

  public class NodeClass
  {
    public string Info { get; set; }
    public NodeClass Next { get; set; }
    public NodeClass Prev { get; set; }
    public NodeClass()
    {
      Info = "";
      Next = null;
      Prev = null;
    }
    public NodeClass(string info)
    {
      Info = info;
      Next = null;
      Prev = null;
    }
    public NodeClass(string info, NodeClass next)
    {
      Info = info;
      Next = next;
      Prev = null;
    }
  }


    // public class NodeClass
    // {
    //   public int Value { get; set; }
    //   public int Next { get; set; }
    //   public NodeClass(int value)
    //   {
    //     Value = value;
    //   }
    // }

    // public class LinkedListClass
    // {
    //   public NodeClass Head { get; set; }
    //   public List<NodeClass> ThisLinkedList { get; set; }
    //   public LinkedListClass()
    //   {
    //     ThisLinkedList = new List<NodeClass>();
    //   }

    //   public void Insert(NodeClass value)
    //   {
    //     // Adds a new NodeClass with that value to the head of the list with an O(1) Time performance.
    //     List<NodeClass> replacement = new List<NodeClass>();
    //     replacement.Add(value);
    //     foreach(var i in ThisLinkedList)
    //       replacement.Add(i);
    //     ThisLinkedList = replacement;
    //     Head = ThisLinkedList.ElementAt(0);
    //   }

    //   public bool Includes(int value)
    //   {
    //     // Indicates whether that value exists as a NodeClass’s value somewhere within the list.
    //     bool tOF = false;
    //     foreach (var v in ThisLinkedList)
    //     {
    //       if (v.Value == value)
    //       {
    //         tOF = true;
    //         break;
    //       }
    //       else
    //         tOF = false;
    //     }
    //     return tOF;
    //   }

    //   public string ToString()
    //   {
    //     // Returns: a string representing all the values in the Linked List, formatted as:
    //     // "{ a } -> { b } -> { c } -> NULL"
    //     string[] theString = new string[ThisLinkedList.Count()];
    //     if (ThisLinkedList.Count() == 0)
    //       return "NULL";
    //     else
    //     {
    //       for (int i = 0; i <= ThisLinkedList.Count() - 1; i++)
    //       {
    //         if (ThisLinkedList.Count() == i + 1)
    //         {
    //           theString[i] = "{ " + (ThisLinkedList.ElementAt(i).Value) + " } -> NULL";
    //         }
    //         else
    //           theString[i] = "{ " + (ThisLinkedList.ElementAt(i).Value) + " } -> ";
    //       }

    //       return String.Join(" ", theString);
    //     }

      // }
    // }
  }
}