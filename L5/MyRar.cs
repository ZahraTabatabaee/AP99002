using System.IO;

public class MyRar :IFile
{
    private string Name{get; set;}
    public MyRar(string name)
    {
        this.Name = name ;
    }
    public void Move()
    {
        System.Console.WriteLine($"RAR {this.Name} is moved");
    }

    public void Delete()
    {
        System.Console.WriteLine($"RAR {this.Name} is deleted");
    }
}