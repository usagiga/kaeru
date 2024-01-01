namespace Otama;

public class Test
{
    [Fact(DisplayName = "To test running xUnit correctly")]
    public void ExampleTest()
    {
        var expected = "Hello, World";
        var actual = "Hello, World";

        Assert.Equal(expected, actual);
    }
}
