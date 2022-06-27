#include<iostream>
#include<vector>
#include<string>
#include<string.h>
using namespace std;

class mystr
{
public: 
    mystr(const char* pch)
        : m_pData(nullptr)
        , m_nsize(0)
    {
        assign(pch);
    }
    ~mystr()
    {
        if(m_pData)
            free(m_pData);
    }
    int get_size()
    {
        // return strlen(m_pData);
        return m_nsize;
    }
    const char* get_data()
    {
        return m_pData ;
    }
    void assign(const char* pch)
    {
        if(m_pData)
            free(m_pData);
        m_nsize = strlen(pch);
        m_pData = (char*)malloc((m_nsize+1) * sizeof(char));
        strcpy(m_pData ,pch);
    }
private:
    int m_nsize;
    char* m_pData;
};

class myvector 
{
public:
    myvector()
    {}

    ~myvector()
    {}

    void resize()
    {}

    void push_back(int x)
    {}

    int get(int i)
    {}
private:
    int* m_pData ;
    int m_nsize ;
    int m_nCapicity ;
};

int main(int argc, char const *argv[])
{
    int x = 5;
    char buf[5] = "asd" ;
    string str = "ali" ; //string ye classe   shabih struct
    str.size() ;
    str = "kdsjam.akeq;olmed,d.sl" ; //ghablan nemitonestim in karo konim
    
    mystr name("hosseingholikhan") ;
    cout << name.get_size() << endl ;
    cout << name.get_data() << endl ;

    name.assign("khaleghezi") ;
    cout << name.get_size() << endl ;
    cout << name.get_data() << endl ;

    for(int i=0 ; i<1000 ; i++)
    {
        mystr name1("ali");
        cout << name1.get_data() << endl ;
    }

    return 0;
}
