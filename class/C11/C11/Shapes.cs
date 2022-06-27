
using System;
using System.Collections;
using System.Collections.Generic;

public interface IShape
{
    void Move(int x, int y);
    string Name {get; set;}
}
public class Point
{
    public int x ;
    public int y ;
    public Point(int x, int y)
    {
        this.x =x ;
        this.y = y;
    }
}
public class Triangle: IShape // Constructor?
{
    public Point p1 ;
    public Point p2 ;
    public Point p3 ;
    public string Name {get; set;}
    public Triangle(string name , Point p1, Point p2, Point p3)
    {
        this.Name = name ;
        this.p1 = p1 ;
        this.p2 = p2 ;
        this.p3 = p3 ;
    }
    public void Move(int x, int y)
    {
        p1.x += x ;
        p1.y += y ;
        p2.x += x ;
        p2.y += y ;
        p3.x += x ;
        p3.y += y ;
    }

}

public class Circle: IShape
{
    public Point p1 ;
    public int Radius ;
    public string Name {get; set;}
    public Circle(string name , Point p1, int r)
    {
        this.Name = name ;
        this.p1 = p1 ;
        this.Radius = r ;
    }
    public void Move(int x, int y)
    {
        p1.x += x ;
        p1.y += y ;
    }
}

public class Square: IShape // Constructor?
{
    public Point p1 ;
    public Point p2 ;
    public Point p3 ;
    public Point p4 ;
    public string Name {get; set;}
    public Square(string name , Point p1, Point p2, Point p3, Point p4)
    {
        this.Name = name ;
        this.p1 = p1 ;
        this.p2 = p2 ;
        this.p3 = p3 ;
        this.p4 = p4 ;
    }
    public void Move(int x, int y)
    {
        p1.x += x ;
        p1.y += y ;
        p2.x += x ;
        p2.y += y ;
        p3.x += x ;
        p3.y += y ;
        p4.x += x ;
        p4.y += y ;
    }

}
    public class BoardEnumerator : IEnumerator<IShape>
    {
        private Board boards;
        public BoardEnumerator(Board b)
        {
            this.boards = b;
        }

        private int Pos = -1;

        public IShape Current
        {
            get
            {
                if (Pos < this.boards.n_Triangles.Length)
                    return this.boards.n_Triangles[Pos-1];
                else if (Pos < (this.boards.n_Triangles.Length + this.boards.n_circles.Length + 1) && Pos>this.boards.n_Triangles.Length)
                    return this.boards.n_circles[Pos - this.boards.n_Triangles.Length - 1] ;
                else
                    return this.boards.n_squares[Pos - this.boards.n_squares.Length - 1];
            }
        }
        object IEnumerator.Current
        {
            get
            {
                return this.Current;
            }
        }

        public void Dispose()
        { }

        public bool MoveNext()
        {
            this.Pos++;
            return this.Pos < this.boards.n_Triangles.Length + this.boards.n_circles.Length + this.boards.n_squares.Length + 1;
        }

        public void Reset()
        {
            this.Pos = -1;
        }
    }
public class Board: IEnumerable<IShape>
{
    public Triangle[] n_Triangles = new Triangle[]{};
    public Circle[] n_circles = new Circle[]{};
    public Square[] n_squares = new Square[]{};
    public List<IShape> n_shapes = new List<IShape>();
    public Board(){}
    public void MoveAllShapes(int x, int y)
    {
        foreach(IShape shape in this.n_shapes)
            shape.Move(x, y);
    }

    public IEnumerable<IShape> Shapes
    {
        get
        {
            foreach(IShape i in n_shapes)
            {
                yield return i ;
            }
        } 
    }

    public void AddShape(IShape s)
    {
        n_shapes.Add(s);
    }

    public IEnumerator<IShape> GetEnumerator()
    {
        foreach(var s in n_shapes)
        {
            if(s==null)
            {
                break;
            }
            yield return s;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return new BoardEnumerator(this);
    }
}

// public class BoardProgram
// {
//     public static void Main3(string[] args)
//     {
//         Board b = new Board();
//         Circle c = new Circle("ball", 1, 2, 3);
//         Circle c2 = new Circle("target", 1, 2, 3);
//         Square s1 = new Square();//("target", 1, 2, 3);
//         b.AddShape(c);
//         b.AddShape(c2);
//         b.AddShape(s1);
//         foreach(IShape s in b)
//         {
//             Console.WriteLine(s.Name);
//         }
//     }
// }