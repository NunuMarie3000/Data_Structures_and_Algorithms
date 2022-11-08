using Class06.Program;
namespace Class06_UnitTest;

public class UnitTest1
{
    [Fact]
    public void Append_ShouldAddValueToEndOfLinkedList()
    {
        LinkedListClass test = new LinkedListClass();
        test.Append(15);
        test.Append(27);
        test.Append(8);
        int whatIThink = 15;
        int actual = test.ElementAt(0);
        Assert.Equal(whatIThink, actual);

    }
}