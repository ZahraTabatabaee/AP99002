// using System;

// namespace C7
// {
//     class Program
//     {
//         class Point
//         {
//             public double x;
//             public double y;
//             public Point(double n_x , double n_y)
//             {
//                 x = n_x ;
//                 y = n_y ;
//             }
//             public Point(Point other)
//             {
//                 x = other.x ;
//                 y = other.y ;
//             }


//         }

//         struct PointV
//         {
//             public double x;
//             public double y;
//             public PointV(double n_x , double n_y)
//             {
//                 x = n_x ;
//                 y = n_y ;
//             }
//             public PointV(Point other)
//             {
//                 x = other.x ;
//                 y = other.y ;
//             }


//         }

//         static double distance(Point a, Point b)
//         {
//             double dis_x = a.x - b.x ;
//             double dis_y = a.y - b.y ;
//             double result = Math.Sqrt(Math.Pow(dis_x , 2) + Math.Pow(dis_y , 2) );
//             return result ;
//         }
//         static double distanceV(PointV a, PointV b)
//         {
//             double dis_x = a.x - b.x ;
//             double dis_y = a.y - b.y ;
//             double result = Math.Sqrt(Math.Pow(dis_x , 2) + Math.Pow(dis_y , 2) );
//             return result ;
//         }
//         static void ProcessPointsRef()
//         {
//             int n;
//             string X1;
//             string X2;
//             string Y1;
//             string Y2;
//             do
//             {
//                 Console.Write("Enter X1? ");
//                 X1 = Console.ReadLine();
//                 Console.Write("Enter Y1? ");
//                 Y1 = Console.ReadLine();
//                 Console.Write("Enter X2?  ");
//                 X2 = Console.ReadLine();
//                 Console.Write("Enter Y2? ");
//                 Y2 = Console.ReadLine();
//             } while(! int.TryParse(X1, out n) && ! int.TryParse(Y1, out n) && ! int.TryParse(X2, out n) && ! int.TryParse(Y2, out n));
//             double X1_d = double.Parse(X1);
//             double Y1_d = double.Parse(Y1);
//             double X2_d = double.Parse(X2);
//             double Y2_d = double.Parse(Y2);
//             Point m1 = new Point(X1_d,Y1_d);
//             Point m2 = new Point(X2_d,Y2_d);
//             double dis_r = distance(m1 , m2) ;
//             Console.WriteLine($"the distance is: {dis_r}");  

//         }

//         static void ProcessPointsValue()
//         {
//             int n;
//             string X1;
//             string X2;
//             string Y1;
//             string Y2;
//             do
//             {
//                 Console.Write("Enter X1? ");
//                 X1 = Console.ReadLine();
//                 Console.Write("Enter Y1? ");
//                 Y1 = Console.ReadLine();
//                 Console.Write("Enter X2?  ");
//                 X2 = Console.ReadLine();
//                 Console.Write("Enter Y2? ");
//                 Y2 = Console.ReadLine();
//             } while(! int.TryParse(X1, out n) && ! int.TryParse(Y1, out n) && ! int.TryParse(X2, out n) && ! int.TryParse(Y2, out n));
//             double X1_d = double.Parse(X1);
//             double Y1_d = double.Parse(Y1);
//             double X2_d = double.Parse(X2);
//             double Y2_d = double.Parse(Y2);
//             PointV m1 = new PointV(X1_d,Y1_d);
//             PointV m2 = new PointV(X2_d,Y2_d);
//             double dis_r = distanceV(m1 , m2) ;
//             Console.WriteLine($"the distance is: {dis_r}");  
//         }



//         // static void Main(string[] args)
//         // {   
//         //     ProcessPointsRef();
//         //     ProcessPointsValue();
//         // }
//     }
// }
