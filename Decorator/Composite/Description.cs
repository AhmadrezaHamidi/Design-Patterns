namespace Composite;
public class Description {


///Creational
///Nehavioral    Patterns
///Structural




}

public abstract class FileSystemOpetion
{
    public abstract long Size();
}



public class Directory : FileSystemOpetion
{
    public List<Directory> Directories { get; set; }
    public List<File> Fiels { get; set; }

    public override long Size()
    {
        long sum = 0; 
        foreach (var item in Directories)
        {
            sum  =+ item.Size();
        }

        foreach (var item in Fiels)
        {
            sum = +item.Size();
        }
        return sum; 
    }
    /*  public int ClaculateSize()
      {
          var size =0;
          foreach (var item in Directories)
          {
             size+=item.ClaculateSize();
          }
          return size; 
      }
  */
}

public class File : FileSystemOpetion
{
    private readonly long SizeP;

    public File(long Size)
    {
        this.SizeP = Size;                       
    }      

    public override long Size()
    {
        return SizeP;
    }
}

