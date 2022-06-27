// // using System;
// // using System.IO;

// namespace cwork
// {
//     public class Person //name, natid, ToString()
//     { 
//         string _Name ;
//         int _NatId ;

//         public Person(string name , int natid)
//         {
//             _Name = name ;
//             _NatId = natid ;
//         }
//         public override string ToString()
//         {
//             return $"name : {_Name}     NatID : {_NatId}" ;
//         }
//     }

//     public class Employee : Person // empid, salary, ToString()
//     {
//         int _EmpId ;
//         double _Salary ;
//         public Employee(string name, int natid , int empid , double salary) : base(name, natid)
//         {
//             _EmpId = empid ;
//             _Salary = salary ;
//         }
//         public override string ToString()
//         {
//             return $"{base.ToString()}     EmpID : {_EmpId}     Salary : {_Salary}" ;
//         }
//     }

//     public class Student : Person // stdid, gpa, ToString()
//     {
//         int _StdId ;
//         double _GPA ;

//         public Student(string name, int natid , int stdid , double gpa) : base(name, natid)
//         {
//             _StdId = stdid ;
//             _GPA = gpa ;
//         }
//         public override string ToString()
//         {
//             return $"{base.ToString()}     StdID : {_StdId}     GPA : {_GPA}" ;
//         }
//     }

//     public class GradudateStudent : Student // thesis_title, ToString()
//     {
//         string _Thesis_Title ;
//         public GradudateStudent(string name, int natid, int stdid, double gpa , string thesis_title) : base(name, natid, stdid, gpa)
//         {
//             _Thesis_Title = thesis_title ;
//         }
//         public override string ToString()
//         {
//             return $"{base.ToString()}     Thesis Title : {_Thesis_Title}" ;
//         } 
//     }

//     public class Instructor : Employee // teacher_rating
//     {
//         double _Teacher_Rating ;
//         public Instructor(string name, int natid, int empid, double salary, double teacher_rating) : base(name, natid, empid, salary)
//         {
//             _Teacher_Rating = teacher_rating;
//         }
//         public override string ToString()
//         {
//             return $"{base.ToString()}     Teacher Rating : {_Teacher_Rating}" ;
//         } 
//     }
//     // class Program
//     // {
//     //     static void Main(string[] args)
//     //     {
//     //         Student S = new Student("Zahra" , 0110142721 , 99521415 , 18.9);
//     //         System.Console.WriteLine( S.ToString());

//     //     }
//     // }
// }