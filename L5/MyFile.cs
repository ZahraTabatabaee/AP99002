using System.IO;

public class MyFile : IFile
{
    public string Name{get; set;}
    public MyFile(string name)
    {
        this.Name = name;
    }
    public void Delete()
    {
        System.Console.WriteLine($"File {this.Name} is deleted");
    }
    public void Move()
    {
        System.Console.WriteLine($"File {this.Name} is moved");
    }
}