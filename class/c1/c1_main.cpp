#include<iostream>
#include<vector>
using namespace std; //baraye inke hey std nanevisim

// int main(int argc, char const *argv[])
// {
//     std::cout << "hello world" << std::endl;
// }

// int main(int argc, char const *argv[])
// {
//     cout << "hello world" << endl;
// }

// int main(int argc, char const *argv[])
// {
//     int n = 5 ;
//     cout << "hello world" << n << endl;
//     cin >> n;
//     string s = "salam chetory";
//     cout << s.size() << endl;
//     string s2 = s + "khaste hastam !";
//     cout << s2 << endl;
//     cin >> s2;
//     cout << "I got this string: " << s2 << endl ;

//     vector<int> mynums ; 
//     mynums.push_back(5);
//     mynums.push_back(3);

//     for (int n : mynums)
//     {
//         cout << n << endl ;
//     }
// }

int main(int argc, char const *argv[])
{
    int n ;
        
    vector<int>nums ;
    while (n != -1)
    {
        cin >> n ; 
        nums.push_back(n);
    }
    cout << "---" << endl ;
    for( int x = (nums.size()-2) ; x>=0 ; x--)
    {
        cout << nums[x] << endl;
    }
}
