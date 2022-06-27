#include<iostream>
#include<string>
#include<vector>
using namespace std;

class Student
{
public:
    Student(string firstName, string lastName, int stdId, string major)
        : m_firstName(firstName)
        , m_lastName(lastName)
        , m_stdId(stdId)
        , m_major(major)
        , unitsum(0)
    {}

    Student(const Student& other)
    {
        m_firstName = other.m_firstName  ;
        m_lastName = other.m_lastName ;
        m_stdId = other.m_stdId;
        m_major = other.m_major ;
    }

    void PrintCompareTranscript(Student& other)
    {
        get_GPA();
        cout << "--------------------" << endl ;
        cout << "NAME            " << m_firstName << m_lastName << "\t\t" << other.m_firstName << other.m_lastName <<  endl ;
        cout << "ID              " << m_stdId << "\t\t" << other.m_stdId <<endl ;
        cout << "MAJOR           " << m_major << "\t\t" << other.m_major << endl ;
        cout << "COURSE GRADE COMPARE :" << endl ;
        for(int i = 0 ; i < m_vCourses.size() ; i++ )
        {
            if(m_vCourses[i]==other.m_vCourses[i])
            {
            cout << m_vCourses[i] <<  "\t\t"  << m_vGrades[i] <<  "\t\t\t" << other.m_vGrades[i] << endl  ;
            }
        }
        cout << "GPA             " << get_GPA() << "\t\t\t" << other.get_GPA() << endl ; 
    } // TODO

    void RegisterGrade(string course, int units, double grade)
    {
        m_vCourses.push_back(course);
        m_vCourseUnit.push_back(units);
        m_vGrades.push_back(grade);
    }

    void PrintTranscript()
    {
        get_GPA();
        cout << "--------------------" << endl ;
        cout << "NAME            " << m_firstName << m_lastName << endl ;
        cout << "ID              " << m_stdId << endl ;
        cout << "MAJOR           " << m_major << endl ;
        cout << "UNITS           " << unitsum << endl ;
        cout << "COURSE NAME - COURSE UNIT - GRADE" << endl ;
        for(int i = 0 ; i < m_vCourses.size() ; i++ )
        {
            cout << m_vCourses[i] <<  "\t\t" << m_vCourseUnit[i] << "\t\t" << m_vGrades[i] << endl ;
        }
        cout << "GPA             " << get_GPA() << endl ; 
    } 

    string get_fullName()
    {
        string fullname = m_firstName + m_lastName ;
        return fullname ;
    } 

    int get_stdId()
    {
        return m_stdId;
    }

    string get_major()
    {
        return m_major ;
    } 

    void PrintFailedCourses()
    {
        for(int i = 0 ; i < m_vCourses.size() ; i++)
        {
            if(m_vGrades[i]<10)
            {
                cout << m_firstName << m_lastName << "faild on " << m_vCourses[i] << "with" << m_vGrades[i] << endl ;
            }
        }
    } 

    double get_GPA()
    {
        for(int i = 0 ; i < m_vCourses.size() ; i++)
        {
            sum = sum + m_vGrades[i]*m_vCourseUnit[i] ;
            unitsum = unitsum + m_vCourseUnit[i];
        }
        double GPA = sum/unitsum ;
        return GPA ;
    } 


    void set_firstName(string firstName)
    {
        this->m_firstName = firstName;
    }

    void set_lastName(string lastName)
    {
        this->m_lastName = lastName;
    }

    void set_stdId(int stdId)
    {
        this->m_stdId = stdId;
    } 

    void set_major(string major)
    {
        this->m_major = major ;
    }

private:
    string m_firstName;
    string m_lastName;
    int m_stdId;
    string m_major;
    vector<int> m_vCourseUnit;
    vector<double> m_vGrades;
    vector<string> m_vCourses;
    double sum = 0 ;
    int unitsum = 0 ;
};


int main(int argc, char const *argv[])
{
    Student mn("zahra", "tabatabaee", 99521415 , "Computer");
    mn.RegisterGrade("FC", 3, 19);
    mn.RegisterGrade("karghah", 1, 19.61);
    mn.RegisterGrade("math1", 3, 19);
    mn.RegisterGrade("english", 3, 18.61);
    mn.RegisterGrade("tafsir", 2, 19);
    mn.PrintTranscript();
    mn.PrintFailedCourses();

    Student nz(mn);
    nz.set_firstName("Aylin");
    nz.set_lastName("Naebzadeh");
    nz.set_stdId(99521111);
    // nz.get_major("cavhvm");
    nz.RegisterGrade("FC", 3, 20);
    nz.RegisterGrade("karghah", 1, 20);
    nz.RegisterGrade("math1", 3, 20);
    nz.RegisterGrade("english", 3, 20);
    nz.RegisterGrade("tafsir", 2, 20);
    nz.RegisterGrade("asf", 2, 20);
    nz.PrintTranscript();
    nz.PrintCompareTranscript(mn);


    /* code */
    return 0;
}
