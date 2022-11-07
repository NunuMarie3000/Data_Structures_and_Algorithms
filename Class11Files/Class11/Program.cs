using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Class11
{
  public class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Code challenge: class 11\n");
      PseudoQueue myQueue = new PseudoQueue();
      // right now my queue is acting like a stack, i'm adding 1, then 2, and when i peek, it's showing what's at the top, when i dequeue, it takes off 2, but if it were a queue, it would take off 1, since it went in first, it should come out first
      myQueue.Enqueue(1);
      myQueue.Enqueue(2);
      myQueue.Enqueue(3);
      myQueue.Enqueue(4);
      Console.WriteLine(myQueue.Peek());
      myQueue.Dequeue();
      Console.WriteLine(myQueue.Peek());
    }

    // ppseudoQueue class
    public class PseudoQueue
    {
      // stack has 3 methods - remember, stack is like stacking dishes
      // push() = adds element to the top of the stack
      // pop() = removes element from top of the stack
      // peek() = you can view the item on the top of the stack without altering it
      public Stack<int> myStack = new Stack<int>();
      // i don't know if i did something wrong, the instructions said to implement 2 instances of stack to handle the queue...right now i'm just doing stack things
      public Stack<int> myOtherStack = new Stack<int>();

      // queue written similarly
      // 3 methods
      // enqueue= push element to end of the queue
      // peek = tells you what the next item in the queue is
      // dequeue = remove whatever is at the front of the line
      public void Enqueue(int value)
      {
        // one argument(value)
        // inserts a value into the pseudoqueue using fifo approach
        myStack.Push(value);
      }
      public void Dequeue()
      {
        // i need to remove the same element that's returned with Peek()
        // i could reverse the stack by popping elements off the top, adding them to myOtherStack, then pop element from top of myOtherStack, then re-reverse the stack back into myStack
        while(myStack.Count != 0)
          myOtherStack.Push(myStack.Pop());

        // Console.WriteLine($"This should be the item to remove: {myOtherStack.ElementAt(0)}");
        myOtherStack.Pop();
        while(myOtherStack.Count != 0)
          myStack.Push(myOtherStack.Pop());

        // extracts a value from the pseudoqueue using fifo approach
        // myStack has elements in lifo order,
        // but whenever i add a new element to myStack, i clear myOtherStack, then add each element in reverse from myStack
        // so dequeue, i wanna remove the element in the bottom of the stack, which will the last element of myStack and first element of myOtherStack
        // dequeue returns element at beginning of the queue, just like the peek() method, but it actually removes it whereas peek() just shows it
        // pop() for stack removes item from to of stack
        // myOtherStack.Pop();
        // myStack.Clear();
        // for (int i = myOtherStack.Count; i <= 0; i--)
        // {
        //   int toAdd = myOtherStack.ElementAt(i);
        //   myStack.Push(toAdd);
        // }

      }
      public int Peek()
      {
        // Peek() should return object at beginning of queue, so bottom of the stack, first in the line
        // since we're using stacks, peek() returns element at the top of the stack, which is the last put in
        // so i should use myOtherStack

        // i could just return whatever is at the bottom of myStack, which would be beginning of a queue
        return (myStack.ElementAt(myStack.Count - 1));
      }
    }
  }
}
