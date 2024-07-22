using Builder.Builder;
using Builder.Productes;

namespace Builder;
public class MazeDirector
{
    //Director 
    //Get instance From builder 

    //Contraction an object using builder infterface  
    private readonly IMazeBuilder _builder;
    public MazeDirector(IMazeBuilder builder)
    {
        _builder = builder;
    }
    public void EasyMAze()
    {
        _builder.AddTitle("title");
        _builder.AddColum("hello");
    }
    public void HardMAze()
    {
        _builder.AddTitle("title");
        _builder.AddColum("GoodBye");
    }
    public Maze Build()
    {
        return _builder.Build();
    }
}
