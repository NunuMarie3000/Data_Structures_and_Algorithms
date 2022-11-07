namespace Class02
{
  public class ProgramTwo
  {
    public static int[] InsertShiftArray(int[] arr, int valueToBeAdded)
    {
      //TAKE TWO
      // 1. find middle of the array
      int middle = (arr.Length) / 2;
      // Console.WriteLine($"Middle is: {middle}");
      // Console.WriteLine(5/2);

      // 2. create new array that's 1+ the size of the original
      int[] newArr = new int[arr.Length + 1];

      // 3. loop through old arr and input values until we get to the middle
      for(int i = 0; i < middle; i++)
        newArr[i] = arr[i];
      
      // 4. add item to middle
      newArr[middle] = valueToBeAdded;

      // 5. input the remaining values
      for(int i = middle + 1; i <= arr.Length; i++)
        newArr[i] = arr[i - 1];
      
      foreach(int num in newArr)
        Console.WriteLine(num);
      return newArr;
    }
  }
}