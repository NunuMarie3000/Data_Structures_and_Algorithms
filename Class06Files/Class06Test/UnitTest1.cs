namespace Class06Test;

public class Class06_UnitTests
{
    [Fact]
    public void Append_ShouldAddElementToEndOfLinkedList()
    {
        Class06.Program.LinkedListClass test = new Class06.Program.LinkedListClass();
        test.Append(10);
        int expected = 10;
        int actual = test.Head.Value;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void InsertBefore_ShouldInsertElementBeforeIndicatedValue()
    {
        Class06.Program.LinkedListClass test = new Class06.Program.LinkedListClass();
        test.Append(20);
        test.Append(30);
        test.Append(40);
        test.InsertBefore(20, 10);
        int expected = 10;
        int actual = test.Head.Value;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void InsertAfter_ShouldInsertElementAfterIndicatedValue()
    {
        Class06.Program.LinkedListClass test = new Class06.Program.LinkedListClass();
        test.Append(10);
        test.Append(30);
        test.Append(40);
        test.InsertAfter(10, 20);
        int expected = 20;
        int actual = test.ThisLinkedList[1].Value;
        Assert.Equal(expected, actual);
    }
}