using product;
namespace product.Test;

public class UnitTest1
{
    [Fact]
    public void Add_TwoNumbers_ReturnsSum()
    {
        var result = Prod.Add(2, 3);
        Assert.Equal(5, result);
    }
}