namespace Class11Tests;

public class UnitTest1
{
  [Fact]
  public void Enqueue_ShouldAddElementToACreatedQueue()
  {
    Class11.Program.PseudoQueue myQueue = new Program.PseudoQueue();
    int expected = 7;
    myQueue.Enqueue(7);
    myQueue.Enqueue(9);

    int actual = myQueue.Peek();
    Assert.Equal(expected, actual);
  }

  [Fact]
  public void Dequeue_ShouldRemoveElementFromQueue()
  {
    Class11.Program.PseudoQueue myQueue = new Program.PseudoQueue();
    int expected = 9;
    myQueue.Enqueue(7);
    myQueue.Enqueue(9);
    myQueue.Dequeue();
    int actual = myQueue.Peek();
    Assert.Equal(expected, actual);
  }
}