using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2
{
    public class Program
    {
    public static int GetObjectType(object o)
    {
        if(o is string)
            return 0;
        if(o is int[] )
            return 1;
        if(o is int )
            return 2;
        else
            return 55 ;
    }
    public static bool IdealHusband(FutureHusbandType fht)
    {
        if(fht == (FutureHusbandType.IsShort | FutureHusbandType.HasBigNose | FutureHusbandType.IsBald)) 
        {
            return false ;
        }
        else if(fht == (FutureHusbandType.IsShort | FutureHusbandType.HasBigNose ) || fht == (FutureHusbandType.IsShort | FutureHusbandType.IsBald ) || fht == (FutureHusbandType.HasBigNose | FutureHusbandType.IsBald ))
        {
            return true ;
        }
        else if(fht == (FutureHusbandType.IsShort ) || fht == (FutureHusbandType.IsBald ) || fht == (FutureHusbandType.HasBigNose ))
        {
            return false ;
        }
        return true ;
    }
        static void Main(string[] args)
        {}

    }
}
