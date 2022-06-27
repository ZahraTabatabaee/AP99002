#include<iostream>
#include<vector>
#include<string>
#include<string.h>
using namespace std;

class myvector
{
private:
    int* nums ;
    int size_nums ;
    int capacity ;
    int* p;
public:
    myvector() : size_nums(0) , capacity(0) , nums(nullptr) 
    {
    }

    // myvector(const myvector& other) //pass by refrence   ye copy dade nemishe
    // {
    //     size_nums = other.size_nums ;
    //     capacity = other.capacity ;
    //     nums = (int*)malloc(capacity*sizeof(int));
    //     for(int i=0 ; i<size_nums ; i++)
    //     {
    //         nums[i]=other.nums[i];
    //     }
    // }

    ~myvector()
    {
        free(nums);
    }
    int size()
    {
        return size_nums;
    }
    void resize()
    {
        p = nums;
        capacity *= 2;
        nums = (int*)malloc(capacity*sizeof(int));
        for(int j = 0 ; j < size_nums ; j++)
        {
            nums[j]=p[j];
        }
        free(p);
    }
    void pushback(int x)
    {
        if(capacity==0)
        {
            capacity++;
            nums = (int*)malloc(capacity * sizeof(int));
            nums[size_nums] = x ;
            size_nums++;
            
        }
        else if(capacity==size_nums)
        {
            resize();
            nums[size_nums] = x ;
            size_nums++;
        }
        else if(size_nums<capacity)
        {
            nums[size_nums]= x ;
            size_nums++;
        }
    }
    int get(int x)
    {
        return nums[x];
    }
};

void swap(int& x, int& y) //lazem nis * bezarim
{
    int tmp = x ;
    x = y ;
    y = tmp ;
}

int main()
{
    int a = 5 , b =4 ;
    swap(a,b);
    myvector v;
    cout << v.size() << endl;
    v.pushback(5);
    v.pushback(3);
    cout << v.size() << endl;
    v.pushback(12);
    v.pushback(15);
    v.pushback(-1);
    v.pushback(0);
    v.pushback(1);
    cout << v.size() << endl;
    for(int i=0; i<v.size(); i++)
        cout << v.get(i) << endl;  

    // myvector v2(v);
}


