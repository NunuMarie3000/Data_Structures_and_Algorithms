using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Implementation_Solution
{
  public class OurLinkedList
  {
    internal OurNode Head { get; set; }

    internal OurNode Tail { get; set; }

    public OurLinkedList()
    {
      Head = new OurNode();
    }
    public OurLinkedList(List<OurNode> nodes)
    {
      //Add All implementation
      Head = nodes.First();
      if (nodes.Count() == 1)
        Head.Next = null;
      else
      {
        Head.Next = nodes[1];
        OurNode Current = Head.Next;

        for(int i = 1; i <= nodes.Count -1; i++)
        {
          if(i != nodes.Count - 1)
          {
            Current.Next = nodes[i + 1];
            Current.Prev = nodes[i - 1];
          }
          else
          {
            Current.Next = null;
            Current.Prev = nodes[i - 1];
            break;
          }
          Current = Current.Next;
        }
        Tail = Current;
      }

    }

    public void AddFirst(OurNode node)
    {
      Head = node;
    }

    public void AddLast(OurNode node)
    {
      // check our head to make sure we have one
      // iterate through that chain of next to see if we have any additional nodes
      if (Head.Next == null)
      {
        Head.Next = node;
      }
      else
      {
        OurNode Current = Head.Next;
        // iterate through what we have
        while (Head.Next != null)
        {
          Console.WriteLine(node.Next);
        }
      }
    }
  }

  public class OurNode
  {
    public string Info { get; set; }
    public OurNode Next { get; set; }
    public OurNode Prev { get; set; }
    public OurNode()
    {
      Info = "";
      Next = null;
      Prev = null;
    }
    public OurNode(string info)
    {
      Info = info;
      Next = null;
      Prev = null;
    }
    public OurNode(string info, OurNode next)
    {
      Info = info;
      Next = next;
      Prev = null;
    }
  }
}