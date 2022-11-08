namespace Class03
{
  public class Program
  {
    static void Main(string[] args)
    {
      int searchKey = 15;
      int[] sortedArr = { 4, 8, 15, 16, 23, 42 };

      Console.WriteLine(BinarySearchDisplay(sortedArr, searchKey));
      // BinarySearch(sortedArr, searchKey);
      // Console.WriteLine(Array.BinarySearch(sortedArr, searchKey));

    }

    public static object BinarySearchDisplay(int[] arr, int key)
    {
      int minNum = 0;
      int maxNum = arr.Length - 1;

      while (minNum <= maxNum)
      {
        int mid = (minNum + maxNum) / 2;
        if (key == arr[mid])
        {
          return ++mid;
        }
        else if (key < arr[mid])
        {
          maxNum = mid - 1;
        }
        else
        {
          minNum = mid + 1;
        }
      }
      return "None";
    }

    // static void BinarySearch(int[] sortedArr, int searchKey)
    // {



    //   List<int> sortedArrList = new List<int>();
    //   foreach(int i in sortedArr)
    //     sortedArrList.Add(i);

    //   int whatToReturn;
    //   int middleIndex = (sortedArrList.Count() - 1) / 2; 
    //   while(whatToReturn == null)
    //   {
    //     if(sortedArrList.ElementAt(middleIndex) == searchKey)
    //       whatToReturn = middleIndex;
    //     else
    //     {
    //       // other operation here

    //     }
    //   }
    // }
  }
}