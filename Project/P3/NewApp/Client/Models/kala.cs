using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class kala
    {
        public int Count = 0;
        public string p_name ;
        public string p_category ;
        public string p_info ;
        public int p_price ;
        public string p_link ;

        public kala(string name, string category , string info , int price, string link)
        {
            p_name = name ;
            p_category = category ;
            p_info = info ; 
            p_price = price ;
            p_link = link ;
        }

    }
}