using System;
using System.Collections;
using System.Collections.Generic;
// DJ'S DEMO CLASSES
using LinkedList_Implementation_Solution;

namespace Class05
{
  public class Program
  {
    static void Main(string[] args)
    {
      // LinkedListClass myLinkedList = new LinkedListClass();

      // myLinkedList.Insert(new Node(10));
      // myLinkedList.Insert(new Node(20));
      // myLinkedList.Insert(new Node(30));
      // myLinkedList.Insert(new Node(40));
      // myLinkedList.Insert(new Node(50));
      // myLinkedList.Insert(new Node(60));

      // Console.WriteLine(myLinkedList.ToString());
      // Console.WriteLine(myLinkedList.Includes(30));


      // NOTE: DJ'S DEMO
      OurNode first = new OurNode("First");
      OurNode second = new OurNode("Second");
      OurNode third = new OurNode("Third");
      OurNode fourth = new OurNode("Fourth");
      OurNode fifth = new OurNode("Fifth");

      List<OurNode> list = new List<OurNode> { first, second, third, fourth, fifth };

      OurLinkedList oll = new OurLinkedList(list);

      // Console.WriteLine(oll.Head.Info);
      // Console.WriteLine(oll.Head.Next.Info);

      // Console.WriteLine(oll.Tail.Prev.Info);
      OurNode c = oll.Head;

      while(c != null)
      {
        Console.WriteLine(c.Info);
        c = c.Next;
      }

      OurNode d = oll.Tail;

      while(d != null)
      {
        Console.WriteLine(d.Info);
        d = d.Prev;
      }
    }


    // public class Node
    // {
    //   public int Value { get; set; }
    //   public int Next { get; set; }
    //   public Node(int value)
    //   {
    //     Value = value;
    //   }
    // }

    // public class LinkedListClass
    // {
    //   public Node Head { get; set; }
    //   public List<Node> ThisLinkedList { get; set; }
    //   public LinkedListClass()
    //   {
    //     ThisLinkedList = new List<Node>();
    //   }

    //   public void Insert(Node value)
    //   {
    //     // Adds a new node with that value to the head of the list with an O(1) Time performance.
    //     List<Node> replacement = new List<Node>();
    //     replacement.Add(value);
    //     foreach(var i in ThisLinkedList)
    //       replacement.Add(i);
    //     ThisLinkedList = replacement;
    //     Head = ThisLinkedList.ElementAt(0);
    //   }

    //   public bool Includes(int value)
    //   {
    //     // Indicates whether that value exists as a Node’s value somewhere within the list.
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