namespace Class10.Classes
{
  public class ANode
  {
    public string Value { get; set; }
    public ANode Next { get; set; }
    public ANode(string value)
    {
      Value = value;
      Next = null;
    }
  }


  public class AStack
  {
    public ANode Top { get; set; }
    public ANode Bottom { get; set; }
    private List<ANode> StackList { get; set; }
    public AStack(List<ANode> nodelist)
    {
      StackList = nodelist;
      Top = StackList[StackList.Count - 1];
      Top.Next = new ANode("NULL");
    }
    public AStack()
    {
      StackList = new List<ANode>();
      Top = new ANode("NULL");
    }

    public void Push(ANode value)
    {
      // adds a node with that value to the top of the stack with an O(1) Time performance
      if (StackList.Count == 0)
      {
        StackList.Add(value);
        Top = value;
      }
      else
      {
        value.Next = Top;
        Top = value;
        // StackList.Add(value);
        List<ANode> tempList = new List<ANode>();
        tempList.Add(value);

        for (int i = 1; i < StackList.Count - 1; i++)
        {
          if (i == StackList.Count - 1)
          {
            StackList[i].Next = new ANode("NULL");
            tempList.Add(StackList[i]);
          }
          else
          {
            StackList[i].Next = StackList[i - 1];
            tempList.Add(StackList[i]);
          }
        }
        StackList = tempList;
      }
    }

    public ANode Pop()
    {
      // returns a value from node from the top of the stack
      // removes the node from the top of the stack
      // should raise exception when called on empty stack
      try
      {
        ANode temp = Top;
        Top = temp.Next;
        StackList.Remove(temp);
        return temp;
      }
      catch (System.Exception)
      {
        Console.WriteLine("Cannot call Pop on an empty stack!");
        throw;
      }
    }

    public ANode Peek()
    {
      return Top;
    }

    public bool IsEmpty()
    {
      if (StackList.Count == 0) return true;
      else return false;
    }
  }




  public class AQueue
  {
    public List<ANode> QueueList;
    public ANode Front { get; set; }
    public ANode Rear { get; set; }

    public AQueue()
    {
      Front = null;
      Rear = new ANode("NULL");
      QueueList = new List<ANode>();
    }
    public AQueue(List<ANode> nodelist)
    {
      Front = nodelist[0];
      Rear = nodelist[nodelist.Count - 1];
      // Rear.Next = new ANode("NULL");
      QueueList = nodelist;
    }

    public void Enqueue(ANode value)
    {
      Console.WriteLine("This is the enqueue method");
      // adds a new node with that value to the back of the queue with an O(1) Time performance.
      if (QueueList.Count == 0)
      {
        Front = value;
        Front.Next = new ANode("NULL");
        Rear = new ANode("NULL");
        QueueList.Add(value);
      }
      else if (QueueList.Count == 1)
      {
        Front = QueueList[0];
        Front.Next = value;
        Rear = value;
        Rear.Next = new ANode("NULL");
      }
      else
      {
        // Rear.Next = value;
        // Rear = value;
        List<ANode> tempList = new List<ANode>();
        for (int i = 1; i <= QueueList.Count; i++)
        {
          if (i == QueueList.Count)
          {
            QueueList.Add(value);
            Rear = value;
            value.Next = new ANode("NULL");
            tempList.Add(value);
          }
          else
          {
            QueueList[i].Next = QueueList[i + 1];
            tempList.Add(QueueList[i]);
          }
        }
        QueueList = tempList;
        Console.WriteLine($"tempListCount: {tempList.Count}");
        Console.WriteLine("This is the middle of the enqueue method");
      }
      // Front = QueueList[0];
      // Front.Next = QueueList[1];
      // Rear.Next = new ANode("NULL");
      Console.WriteLine("This is the end of the enqueue method");
    }

    public ANode Dequeue()
    {
      // Returns: the value from node from the front of the queue
      // Removes the node from the front of the queue
      // Should raise exception when called on empty queue
      try
      {
        ANode temp = Front;
        Front = Front.Next;
        temp.Next = null;
        QueueList.Remove(temp);
        return temp;
      }
      catch (System.Exception)
      {
        Console.WriteLine("Cannot call Dequeue on an empty queue!");
        throw;
      }
    }

    public ANode Peek()
    {
      return Front;
    }

    public bool IsEmpty()
    {
      if (QueueList.Count == 0)
        return true;
      else
        return false;
    }
  }














  // public class TheNode
  // {
  //   public string Value { get; set; }
  //   public TheNode Next { get; set; }
  //   public TheNode(string value)
  //   {
  //     Value = value;
  //     Next = null;
  //   }
  // }

  // public class TheStack
  // {
  //   public TheNode Top { get; set; }

  //   public List<TheNode> ActualStack;
  //   public TheStack()
  //   {
  //     ActualStack = new List<TheNode>();
  //     Top = null;
  //   }

  //   public void Push(TheNode value)
  //   {
  //     // adds value to top of the stack with O(1) performance
  //     // if there's no values, we can simply add and set node's next prop to null
  //     if (ActualStack.Count == 0)
  //     {
  //       ActualStack.Add(value);
  //       Top = value;
  //       value.Next = null;
  //     }
  //     else
  //     {
  //       // if there are values
  //       // we need to add the input value before the value already in the list, what way it acts like stack
  //       // ActualStack.AddLast(value);
  //       // however, we can't just do this, we have to reassign each node's next property
  //       TheNode Current = Top;
  //       Top = value;
  //       //temporary list
  //       List<TheNode> tempList = new List<TheNode>();
  //       tempList.Add(Current);
  //       for (int i = 0; i <= ActualStack.Count-1; i++)
  //       {
  //         // iterate through the length of the list, decreasing
  //         // imma imagine there's only one other value "First"
  //         // we need it to look like
  //         // Second
  //         // First
  //         // even though lists look like
  //         // First
  //         // Second
  //         // so insert element before whatever is there
  //         // rn the current is the top
  //         // as we loop through, set current to the next value
  //         if (i == ActualStack.Count - 1)
  //         {
  //           Current = ActualStack[i];
  //           Current.Next = null;
  //           tempList.Add(Current);
  //         }
  //         else
  //         {
  //           Current = ActualStack[i];
  //           Current.Next = ActualStack[i + 1];
  //           tempList.Add(Current);
  //         }
  //         Current = Current.Next;
  //       }
  //       // ActualStack = tempList;
  //     }
  //   }

  //   public void Pop()
  //   {

  //   }

  // public void Peek()
  //   {

  //   }

  //   public bool IsEmpty()
  //   {
  //      if(ActualStack.Count == 0)
  //        return true;
  //      else
  //        return false;
  //   }
  // }
}