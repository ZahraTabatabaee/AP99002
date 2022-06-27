#include<vector>
#include<string>
#include<string.h>
#include<iostream>

using namespace std;

class University
{
private:

public:
    string uni_name;
    string uni_address;
    University(const string& name, const string& address)
        : uni_name(name)
        , uni_address(address)
    {}
    void PrintInfo()
    {
        cout << "UNIVERSIT INFORMATIONS" << endl;
        cout << "NAME :" <<  endl ;
        cout << "  + " << uni_name << endl ;
        cout << "ADDRESS :" << endl ;
        cout << "  + " << uni_address << endl ;
        cout << "------------------------------" << endl;
    }
};

class Instructor
{
private:

public:
    University i_uni_name;
    string i_name;
    int i_id;
    string i_department;
    Instructor(const University& univ, string name, int id, string department)
        : i_uni_name(univ)
        , i_name(name)
        , i_id(id)
        , i_department(department)
    {}
    void PrintInfo()
    {
        cout << "INSTRUCTOR INFORMATIONS" << endl;
        cout << "NAME :" <<  endl ;
        cout << "  + " << i_name << endl ;
        cout << "ID :" << endl ;
        cout << "  + " << i_id << endl ;
        cout << "UNIVERSITY :" <<  endl ;
        cout << "  + " << i_uni_name.uni_name << endl ;
        cout << "DEPARTMENT :" << endl ;
        cout << "  + " << i_department << endl ;
        cout << "------------------------------" << endl;
    }
};

class Course
{
private:

public:
    University c_uni_name ;
    Instructor c_i_name ;
    string c_name ;
    double c_grade ;
    int c_unit ;
    Course(const University& univ, const Instructor& instructor, const string& name, double grade, int unit)
        : c_uni_name(univ)
        , c_i_name(instructor)
        , c_name(name)
        , c_grade(grade)
        , c_unit(unit)
    {}

    string get_name()
    {
        return c_name ;
    }
    void PrintInfo()
    {
        cout << "COURSE INFORMATIONS" << endl;
        cout << "UNIVERSITY :" <<  endl ;
        cout << "  + " << c_uni_name.uni_name << endl ;
        cout << "NAME :" << endl ;
        cout << "  + " << c_name << endl ;
        cout << "INSTRUCTOR :" <<  endl ;
        cout << "  + " << c_i_name.i_name << endl ;
        cout << "UNIT :" << endl ;
        cout << "  + " << c_unit << endl ;
        cout << "GRADE :" << endl ;
        cout << "  + " << c_grade << endl ;
        cout << "------------------------------" << endl;       
    }

};

class Student
{
public: 
    University s_uni_name ;
    string s_name ;
    int s_id ;
    string s_major; 

    Student(const University& univ, const string& name, int id, const string& major)
        : s_uni_name(univ)
        , s_name(name)
        , s_id(id)
        , s_major(major)
        {

        }

    void PrintInfo()
    {
        cout << "STUDENT INFORMATIONS" << endl;
        cout << "UNIVERSITY :" <<  endl ;
        cout << "  + " << s_uni_name.uni_name << endl ;
        cout << "NAME :" << endl ;
        cout << "  + " << s_name << endl ;
        cout << "ID :" <<  endl ;
        cout << "  + " << s_id << endl ;
        cout << "MAJOR :" << endl ;
        cout << "  + " << s_major << endl ;
        cout << "------------------------------" << endl;    
    }

    void RegisterCourse(const Course& course)
    {
        m_Courses.push_back(course);
    }
    void RegisterGrade(const string& name , double grade)
    {
        for(int i = 0 ; i < m_Courses.size() ; i++)
        {
            if(name==m_Courses[i].get_name())
            {
                m_Courses[i].c_grade = grade ;
            }
        }

    }
    void PrintTranscript()
    {
        cout << "PRINT TRANSCRIPT" << endl;
        cout << "UNIVERSITY :" <<  endl ;
        cout << "  + " << s_uni_name.uni_name << endl ;
        cout << "NAME :" << endl ;
        cout << "  + " << s_name << endl ;
        cout << "ID :" <<  endl ;
        cout << "  + " << s_id << endl ;
        cout << "MAJOR :" << endl ;
        cout << "  + " << s_major << endl ;
        cout << "GRADES :" << endl ;
        for(int i = 0 ; i < m_Courses.size() ; i++)
        {
            cout << "  + " << m_Courses[i].c_name << "\t" << m_Courses[i].c_grade << endl ;
        }
        cout << "------------------------------" << endl;     
    }

private:
    vector<Course> m_Courses;
};


int main(int argc, char const *argv[])
{
    University iust("Iran University of Science and Technology", "Median resalat....");
    iust.PrintInfo();
    Instructor ostad_hoseini(iust, "hosseini", 923423, "Math");
    ostad_hoseini.PrintInfo();
    Course math101(iust, ostad_hoseini, "Math 101", 0, 3);
    math101.PrintInfo();
    Student sara(iust, "sara pejmani", 98342342, "EE");
    sara.PrintInfo();
    sara.RegisterCourse(math101);
    sara.RegisterGrade("Math 101", 19.8);
    sara.PrintTranscript();

    return 0;
}
