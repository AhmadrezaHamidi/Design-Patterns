namespace Decorator;

public interface ICompoition {
    public string Calculate();
}


public class Compoition : ICompoition
{
    public string Calculate()
    {
        return "2";
    }
}

public class InheriFromCompo : ICompoition
{
    private readonly ICompoition compoition;
    public InheriFromCompo(ICompoition compoition)
    {
        this.compoition = compoition;
    }

    public string Calculate()
    {
        return  $"{compoition.Calculate()} + Hello ";
    } 
}






