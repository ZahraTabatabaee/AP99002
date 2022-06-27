#pragma once
#include <string>
#include <vector>
#include <string.h>
#include <iostream>
#include "Book.cpp"
//1
using namespace std;

namespace A1
{
    const int InitialBorrowDays = 120;
    class Library
    {
    public:
        Library()
        {
            V_book = nullptr;
            V_member = nullptr;
        }
        Library(string Name)
        {
            a_Name = Name;
        }
        Library(const Library &C_library)
        {
            *(V_book) = *(C_library.V_book);
        }
        ~Library()
        {
            if (V_book != nullptr)
            {
                for (int i = 0; i < V_book->size(); i++)
                {
                    delete (*V_book)[i];
                }
                delete V_book;
                V_book = nullptr;
            }
            if (V_member != nullptr)
            {
                for (int i = 0; i < V_member->size(); i++)
                {
                    delete (*V_member)[i];
                }
                delete V_member;
                V_member = nullptr;
            }
        }
        void AddBook(Book *A)
        {
            (*V_book).push_back(A);
        }
        string GetName()
        {
            return a_Name;
        }
        vector<Book *> *GetAllBooks()
        {
            return V_book;
        }
        void SetName(string n_name)
        {
            a_Name = n_name;
        }
        vector<Member *> *GetAllMembers()
        {
            return V_member;
        }
        void RegisterMember(Member *C)
        {
            if (C->GetSavingMoney() >= 1000)
            {
                (*V_member).push_back(C);
                C->is_registerd = true;
                C->set_money(C->GetSavingMoney() - 1000);
            }
        }
        void SortMembersByName()
        {
            for (int i = 0; i < (V_member->size()); i++)
            {
                for (int j = 0; j < (V_member->size()); j++)
                {
                    if (((*V_member)[i]->GetName()) < ((*V_member)[j]->GetName()))
                    {
                        Member *tmp = (*V_member)[i];
                        (*V_member)[i] = (*V_member)[j];
                        (*V_member)[j] = tmp;
                    }
                }
            }
        }
        void DaysPassed(int day)
        {
            for (int idx = 0; idx < this->V_book->size(); idx++)
            {
                auto book = (*this->V_book)[idx];
                if (book->IsBorrowedB())
                {
                    auto mem = book->mem;
                    mem->set_money(mem->GetSavingMoney() - (day * book->GetPrice() / 10));
                }
            }
        }
        void BorrowBook(Book *b_book, Member *b_member)
        {
            if (b_member->is_registerd == true)
            {
                if (b_member->is_borrowed == false)
                {
                    if (b_book->is_borrowedB == false)
                    {
                        int price = (b_book->GetPrice() / 4);
                        if ((b_member->GetSavingMoney()) >= price)
                        {
                            int n_m = (b_member->GetSavingMoney());
                            b_member->set_money(n_m - price);
                            b_member->is_borrowed = true;
                            b_book->is_borrowedB = true;
                            b_book->mem = b_member;
                        }
                    }
                }
            }
        }
        vector<Book *> *FindBooks(string type, float rate)
        {
            vector<Book *> *findb = new vector<Book *>();
            for (int i = 0; i < (V_book->size()); i++)
            {
                string lower = (*V_book)[i]->GetCategory();
                for (int j = 0; j < lower.size(); j++)
                {
                    lower[j] = tolower(lower[j]);
                }
                for (int z = 0; z < type.size(); z++)
                {
                    type[z] = tolower(type[z]);
                }
                if (((*V_book)[i]->GetRating() >= rate))
                {
                    size_t found = lower.find(type);
                    if (found != string::npos)
                    {
                        (*findb).push_back((*V_book)[i]);
                    }
                }
            }
            return findb;
        }

    private:
        string a_Name;
        vector<Book *> *V_book = new vector<Book *>();
        vector<Member *> *V_member = new vector<Member *>();
    };
}
