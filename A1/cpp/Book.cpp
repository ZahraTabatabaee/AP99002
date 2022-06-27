#pragma once
#include<string>
#include<string.h>
#include "Member.cpp"

namespace A1
{
    class Book
    {
        public:
        Book(){}
        Book(string Author, string Title, long int Price, float Rating, string ISBN_10, string PublishDate, string Category )
        : a_Author(Author), a_Title(Title), a_Price(Price), a_Rating(Rating), a_ISBN_10(ISBN_10), a_PublishDate(PublishDate), a_Category(Category)
        {}
        Book(const Book& c_book)
        {
            this->a_Author = c_book.a_Author;
            this->a_Title = c_book.a_Title ; 
            this->a_Price = c_book.a_Price ; 
            this->a_Rating = c_book.a_Rating ; 
            this->a_ISBN_10 = c_book.a_ISBN_10 ; 
            this->a_PublishDate = c_book.a_PublishDate ; 
            this->a_Category = c_book.a_Category ;    
        }
        string GetAuthor()
        {
            return a_Author ;
        }
        string GetTitle()
        {
            return a_Title ;
        }
        long int GetPrice()
        {
            SetPrice(a_Price);
            return a_Price ;
        }
        float GetRating()
        {
            return a_Rating ;
        }
        string GetCategory()
        {
            return a_Category;
        }
        void SetPrice(int n_price)
        {
            int cut = n_price%100 ;
            if(cut>0)
            {
                a_Price = n_price - cut +100 ;
            }
            else
            {
                a_Price = n_price ;
            }
        }

        void SetRating(double n_rating)
        {
            if(1<n_rating && n_rating<5)
            {
                a_Rating = n_rating ;
            }
        }

        bool IsBorrowedB()
        {
            return is_borrowedB ;
        }
        void Setborrowed(bool i)
        {
            is_borrowedB = i;
        }
        void Setmem(Member* newmem)
        {
            mem = newmem ;
        }
        Member* Getmem()
        {
            return mem;
        }
        
        private:
        string a_Author;
        string a_Title; 
        long int a_Price; 
        float a_Rating; 
        string a_ISBN_10; 
        string a_PublishDate; 
        string a_Category;
        bool is_borrowedB = false ;
        Member* mem ;


    };
}