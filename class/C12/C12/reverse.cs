using System;
using System.Collections.Generic;
using System.IO;
namespace C12
{
    public class revese
    {
        public static void ReverseTextFile(string first, string second)
        {
            using(StreamReader Read = new StreamReader(first))
            {
                using(StreamWriter Write = new StreamWriter(second))
                {
                    List<string> s_list = new List<string>() ;
                    string Line;
                    while( null != (Line = Read.ReadLine()))
                    {
                        s_list.Add(Line);
                    }
                    for(int i=0 ; i<(s_list.Count)/2 ; i++)
                    {
                        string s = s_list[i];
                        s_list[i] = s_list[s_list.Count-i-1];
                        s_list[s_list.Count-i-1] = s;
                    }
                    foreach(string l in s_list)
                        Write.WriteLine(l);
                }
            }
        }
    }
}