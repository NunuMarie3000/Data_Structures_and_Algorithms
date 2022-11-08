namespace Class04
{
  public class Program
  {
    static void Main(string[] args)
    {
      QuestionOne();
      // QuestionTwo();
    }

    public void QuestionOne()
    {
      // Ask the candidate to write a function to add up the sum of each row in a matrix of arbitrary size, and return an array with the appropriate values.
      // Avoid utilizing any of the built-in methods available to your language.
      // Don’t let the candidate get scared by the term “matrix”… It’s just an array of arrays.
      // The matrix will always be full of integers.
      // Negative values are possible.
      // All nulls will be counted as zeros.
    }

    public void QuestionTwo()
    {
      // As an interviewer, familiarize yourself with the Fibonacci Sequence
      //Ask the candidate to write a function to accepts an integer, and returns the nth number in the Fibonacci sequence.
      // You should be able to check their work for small values of n: if fib(n) is equal to fib(n-1) + fib(n-2).
      // Encourage the candidate to work quickly towards a first solution, that is either recursive or iterative (with a while or for loop).
      // Then ask the candidate to solve it with the other approach (eg: if they first used an iterative solution, ask for a recursive solution)
      // Evaluate and compare the Big-O of both solutions.
      // The recursive solution might be as bad as O(2n)—that’s 2 to the power of n— which is so bad most laptops would take a while to solve for n larger than about 40.
      // The iterative solution should be roughly O(n), which means a laptop could find answers for large values of n.
      // There is also an O(1) solution, based on a mathematical formula… Not likely anyone will know this without looking it up! (Did you see the formula on the page about the sequence linked above?) If time allows, try to implement the formula with the candidate.
      // Avoid utilizing any of the built-in methods available to your language.
    }
  }
}