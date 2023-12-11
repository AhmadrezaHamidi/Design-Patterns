using Decorator;

namespace Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var inPut = new Compoition();
        var serlize = new InheriFromCompo(inPut);


    }
}
