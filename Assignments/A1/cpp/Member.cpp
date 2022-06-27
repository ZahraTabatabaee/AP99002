#pragma once
#include <string.h>
#include <string>
#include <vector>
using namespace std;
//1
namespace A1
{
    class Member
    {
    public:
        Member() {}
        Member(int Num, string Name)
        {
            a_Name = Name;
            a_Num = Num;
        }
        Member(const Member &C_member)
        {
            a_Num = C_member.a_Num;
        }
        ~Member()
        {
            delete V_member;
            V_member = nullptr;
        }
        int GetSavingMoney()
        {
            return a_Num;
        }
        string GetName() const
        {
            return a_Name;
        }
        void set_money(int n_money)
        {
            a_Num = n_money;
        }
        void set_name(string n_name)
        {
            a_Name = n_name;
        }
        bool is_registerd = false;
        bool is_borrowed = false;
        bool IsBorrowed()
        {
            return is_borrowed;
        }
        bool ISregisterd()
        {
            return is_registerd;
        }

    private:
        int a_Num;
        string a_Name;
        vector<Member *> *V_member = new vector<Member *>();
    };
}