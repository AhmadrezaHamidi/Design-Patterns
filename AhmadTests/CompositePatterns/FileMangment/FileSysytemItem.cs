using System.Reflection.PortableExecutable;

namespace CompositePatterns.FileMangment;

//
//


public abstract record FileSistemItem
{
    //1Define a abstract and callled Componoinet 
    // Component
    public abstract long Size();
}

public record File(int size) : FileSistemItem 
{
    // Primitive
    //Leaf
    public override long Size() => size;
}

public record Directory(params FileSistemItem[] _Files)   : FileSistemItem
{
    //Composite   part of  struct  Component 
    // notes : implimented in old version 
    // public List<Directory> ChildrenDirectories { get; set; }
    // public List<File> childremFiles { get; set; }
    //notes : new version 
    public override long Size() => _Files.Sum(x => x.Size());
}

public class TestProj
{
    private readonly Directory _Directory;

    public TestProj()
    {
        var files = new File(20);
        var files1 = new File(20);
        var files2 = new File(20);
        var direcory = new Directory(files, files1);
        _Directory = new Directory(files2, direcory);
    }
    public long GetSizes() => _Directory.Size();
}

