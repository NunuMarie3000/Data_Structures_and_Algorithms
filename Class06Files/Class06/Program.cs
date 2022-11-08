using System;
using System.Collections;
using System.Collections.Generic;

namespace Class06
{
  public class Program
  {
    static void Main(string[] args)
    {
      // LinkedListClass myLinkedList = new LinkedListClass();

      // // myLinkedList.Append(10);
      // // myLinkedList.Insert(20);
      // myLinkedList.Append(30);
      // // myLinkedList.Insert(40);
      // myLinkedList.Append(50);
      // // myLinkedList.Insert(60);
      // myLinkedList.Insert(10);

      // Console.WriteLine(myLinkedList.ToString());
      // Console.WriteLine(myLinkedList.Includes(30));


      LinkedListClass test = new LinkedListClass();
      test.Append(1);
      test.Append(2);
      test.Append(2);

      Console.WriteLine(test.ToString());
      test.InsertAfter(2, 5);
      Console.WriteLine(test.ToString());
    }

    public class Node
    {
      public int Value { get; set; }
      public int Next { get; set; }
      public Node(int value)
      {
        Value = value;
      }
    }

    public class LinkedListClass
    {
      public Node Head { get; set; }
      public List<Node> ThisLinkedList { get; set; }
      public LinkedListClass()
      {
        ThisLinkedList = new List<Node>();
      }

      public void Insert(int value)
      {
        // Adds a new node with that value to the head of the list with an O(1) Time performance.
        Node newValue = new Node(value);
        ThisLinkedList.Insert(0, newValue);
        Head = newValue;
        // if the above isn't allowed, i'd have to create a new list, iterate through ThisLinkedList, and readd values with the input value as the first element
      }

      public bool Includes(int value)
      {
        // Indicates whether that value exists as a Node’s value somewhere within the list.
        bool tOF = false;
        foreach (var v in ThisLinkedList)
        {
          if (v.Value == value)
          {
            tOF = true;
            break;
          }
          else
            tOF = false;
        }
        return tOF;
      }

      public string ToString()
      {
        // Returns: a string representing all the values in the Linked List, formatted as:
        // "{ a } -> { b } -> { c } -> NULL"
        string[] theString = new string[ThisLinkedList.Count()];
        if (ThisLinkedList.Count() == 0)
          return "NULL";
        else
        {
          for (int i = 0; i <= ThisLinkedList.Count() - 1; i++)
          {
            if (ThisLinkedList.Count() == i + 1)
            {
              theString[i] = "{ " + (ThisLinkedList.ElementAt(i).Value) + " } -> NULL";
            }
            else
              theString[i] = "{ " + (ThisLinkedList.ElementAt(i).Value) + " } -> ";
          }

          return String.Join(" ", theString);
        }
      }


      // NEW ADDITIONS FOR CLASS06
      public void Append(int value)
      {
        // adds a new node with the given value to the end of the list
        Node newValue = new Node(value);
        ThisLinkedList.Add(newValue);
        Head = ThisLinkedList[0];
      }

      public void InsertBefore(int value, int newValue)
      {
        // adds a new node with the given new value immediately before the first node that has the value specified
        Node NewValue = new Node(newValue);
        if (ThisLinkedList.ElementAt(0).Value == value)
          Head = NewValue;
        foreach (var i in ThisLinkedList)
        {
          if (i.Value == value)
          {
            int index = ThisLinkedList.IndexOf(i);
            ThisLinkedList.Insert(index, NewValue);
            return;
          }
        }
      }

      public void InsertAfter(int value, int newValue)
      {
        // adds a new node with the given new value immediately after the first node that has the value specified
        foreach (var i in ThisLinkedList)
        {
          if (i.Value == value)
          {
            int index = ThisLinkedList.IndexOf(i);
            ThisLinkedList.Insert(index + 1, new Node(newValue));
            return;
          }
        }
      }
    }
  }
}
