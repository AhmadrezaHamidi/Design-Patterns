using Builder.Productes;

namespace Builder.Builder
{
    //separate the construction of a complex object from its represention so that the 
    //same construction procress can create different represention 



    /// <summary>
    /// dufferent out put ithe same make  progress 
    /// </summary>


    public interface IMazeBuilder
    {
        //Builder 
        //specifies an abstraction interface for createing of a product object 
        void AddTitle(string title);
        void AddColum(string colum);

        Maze Build();
    }

}
