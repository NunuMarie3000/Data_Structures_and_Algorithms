namespace Class08.Classes
{
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
      List<Node> replacement = new List<Node>();
      replacement.Add(value);
      foreach (var i in ThisLinkedList)
        replacement.Add(i);
      ThisLinkedList = replacement;
      Head = ThisLinkedList.ElementAt(0);
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

    public void ZipLists(LinkedListClass one, LinkedListClass two)
    {
      //Write a function called zip lists
      //Arguments: 2 linked lists
      //Return: New Linked List, zipped as noted below
      //Zip the two linked lists together into one so that the nodes alternate between the two lists and return a reference to the the zipped list.
      //Try and keep additional space down to O(1)
      //You have access to the Node class and all the properties on the Linked List class as well as the methods created in previous challenges.

      // i would create a new list
      // use a for loop, let i = 0, i < one.Count -1 + two.Count -1, i++
      // newList.Add(one[i])
      // newlist.Add(two[i])
      
      // then, did another loop, 
      // Head = newlist[0];
      // current = Head
      // do for loop to iterate through newlist and assign current.next, etc. 
    }
  }
}