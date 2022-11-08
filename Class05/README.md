# Code Challenge: Class 05 - Implementation: Singly Linked Lists

## Challenge

1. Node

- Create a Node class that has properties for the value stored in the Node, and a pointer to the next Node.

1. Linked List

- Create a Linked List class
  - Within your Linked List class, include a head property.
  - Upon instantiation, an empty Linked List should be created.
  - The class should contain the following methods:
    - insert
      - Arguments: value
    - Returns: nothing
      - Adds a new node with that value to the head of the list with an O(1) Time performance.
    - includes
      - Arguments: value
      - Returns: Boolean
      - Indicates whether that value exists as a Node’s value somewhere within the list.
    - to string
      - Arguments: none
      - Returns: a string representing all the values in the Linked List, formatted as:
        - "{ a } -> { b } -> { c } -> NULL"

## Approach & Efficiency

First I created all my classes with empty methods as per the instructions.

- Node class

  - The Node class has an integer Value, as well as a constructor that assigns it's input value to the class's Value property

```cs
  public int Value { get; set; }
  public Node(int value)
  {
    Value = value;
  }
```

- LinkedList class

  - The Linked List class' non-method properties are: 

    - Head: which is an instance of Node, it's value will be the first item in the LinkedList whenever one is added

    - ThisLinkedList: a list of Node elements

    - LinkedListClass constructor which sets ThisLinkedList property to a new List of Node elements whenever a new instance of the LinkedList class is created

```cs
public Node Head { get; set; }
public List<Node> ThisLinkedList { get; set; }
public LinkedListClass()
{
  ThisLinkedList = new List<Node>();
}
```

## API

- LinkedList Class Methods:

  - Insert : adds a new node with the input value to the head of the list, also sets the Head Node to the first element

```cs
public void Insert(Node value)
{
  List<Node> replacement = new List<Node>();
  replacement.Add(value);
  foreach(var i in ThisLinkedList)
    replacement.Add(i);
  ThisLinkedList = replacement;
  Head = ThisLinkedList.ElementAt(0);
}
```

  - Includes : returns a boolean value, depending upon whether or not the input value exists somewhere in the list

```cs
public bool Includes(int value)
{
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
```

  - ToString : returns a string representing all values in the linked list, formatted as:

    - "{ a } -> { b } -> { c } -> NULL"

```cs
public string ToString()
{
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
```
