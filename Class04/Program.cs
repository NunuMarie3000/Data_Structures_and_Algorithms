namespace Class04
{
  public class Program
  {
    static void Main(string[] args)
    {
      int[,] myArr = {{1, 2, 3}, {3, 5, 7}, {1, 7, 10}};
      int[,] anotherArr = {{0, 1, 5}, {-4, 7, 2}, {-3, 12, 11}};
      // looks like
        // {1, 2, 3}
        // {3, 5, 7}
        // {1, 7, 10}
      QuestionOne(anotherArr);
      // QuestionOne(myArr);
      // Console.WriteLine(QuestionTwo(7));
    }

    public static void QuestionOne(int[,] arr)
    {
      // Ask the candidate to write a function to add up the sum of each row in a matrix of arbitrary size, and return an array with the appropriate values.
      // Avoid utilizing any of the built-in methods available to your language.
      // Negative values are possible.
      // All nulls will be counted as zeros.
      // Console.WriteLine(arr.GetLength(0));
      int numberOfRows = arr.GetLength(0);
      int itemsInRow = arr.GetLength(1);
      int totalSum = 0;
      for(int i = 0; i <= numberOfRows - 1; i++) // for each row in the input array
      {
        for(int j = 0; j <= itemsInRow - 1; j++) // for each item in the row
        // Console.Write(arr[i, j] + " ");
        totalSum += arr[i, j];
      }
      Console.WriteLine(totalSum);
      // Console.WriteLine("[ " + numberOfRows + ", " + itemsInRow + " ]"); // these are the dimensions of the input array
    }

    /*public static int QuestionTwo(int n)
    {
      // return nth number in the Fibonacci sequence.
      // You should be able to check their work for small values of n: if fib(n) is equal to fib(n-1) + fib(n-2).
      // counter is what's gonna keep up with the nth fib we're on

      // =============================== Recursive ===============================
      // if(n == 0) return 0;
      // if(n == 1) return 1;
      // return QuestionTwo(n - 1) + QuestionTwo(n - 2);
      // =============================== For Loop ================================
      // int first = 0;
      // int second = 1;
      // int current = 0;

      // if (n == first) return first;
      // if (n == second) return second;

      // for (int i = 2; i <= n; i++)
      // {
      //   current = first + second;
      //   first = second;
      //   second = current;
      // }
      // return current;
    }*/
  }
}