namespace Class03
{
  public class Program
  {
    static void Main(string[] args)
    {
      int searchKey = 15;
      int[] sortedArr = {4, 8, 15, 16, 23, 42};

      BinarySearch(sortedArr, searchKey);
      // Console.WriteLine(Array.BinarySearch(sortedArr, searchKey));

    }

    static void BinarySearch(int[] sortedArr, int searchKey)
    {
      


      // List<int> sortedArrList = new List<int>();
      // foreach(int i in sortedArr)
      //   sortedArrList.Add(i);
      
      // int whatToReturn;
      // int middleIndex = (sortedArrList.Count() - 1) / 2; 
      // while(whatToReturn == null)
      // {
      //   if(sortedArrList.ElementAt(middleIndex) == searchKey)
      //     whatToReturn = middleIndex;
      //   else
      //   {
      //     // other operation here

      //   }
      // }
    }
  }
}