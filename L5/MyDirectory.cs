using System;
using System.Collections.Generic;
using System.IO;

public class MyDirectory :IFile
{
    public string Name{get; set;}
    public List<IFile> Items{get; set;} = new List<IFile>{} ;
    public MyDirectory(string name)
    {
        this.Name = name ;
    }
    public void Color(string s)
    {
        var tmp = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red ;
        Console.WriteLine(s);
        Console.ForegroundColor = tmp ;
    }
    public void Add(params IFile[] obj)
    {

        this.Items.AddRange(obj);
    }
    public void Delete()
    {

        foreach (IFile item in this.Items)
            item.Delete();
        this.Color($"Directory {this.Name} is deleted");

    }
    public void Move()
    {
        foreach (IFile item in this.Items)
            item.Move();
        this.Color($"Directory {this.Name} is moved");
    }

}