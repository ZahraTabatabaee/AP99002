using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace A2
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct TypeOfSize5
    {
        char a1;
        char a2;
        char a3;
        char a4;
        char a5;
    }
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct TypeOfSize22
    {
        char a;
        char a1 ;
        TypeOfSize5 b1 ;
        TypeOfSize5 b2 ;
        TypeOfSize5 b3 ;
        TypeOfSize5 b4 ;

    }
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct TypeOfSize125
    {
        TypeOfSize5 b1 ;
        TypeOfSize5 b2 ;
        TypeOfSize5 b3 ;
        TypeOfSize22 c1 ;
        TypeOfSize22 c2 ;
        TypeOfSize22 c3 ;
        TypeOfSize22 c4 ;
        TypeOfSize22 c5 ;
    }
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct TypeOfSize1024
    {
        char a1 ;
        char a2 ;
        TypeOfSize22 c1 ;
        TypeOfSize125 d1 ;
        TypeOfSize125 d2 ;
        TypeOfSize125 d3 ;
        TypeOfSize125 d4 ;
        TypeOfSize125 d5 ;
        TypeOfSize125 d6 ;
        TypeOfSize125 d7 ;
        TypeOfSize125 d8 ;
    }
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct TypeOfSize32768
    {
        TypeOfSize1024 e1 ,e2 , e3 ,e4 ,e5 ,e6 , e7 ,e8 ,e9 ,e10 , e11 ,e12 ,e13 ,e14 , e15 ,e16 ,e17 ,e18 , e19 ,e20 ,e21 ,e22 , e23 ,e24 ,e25 ,e26 , e27 ,e28 ,e29 ,e30 , e31 ,e32 ;
    }
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct TypeForMaxStackOfDepth10
    {
        TypeOfSize32768 f1 ;
        TypeOfSize1024 e1 ,e2 , e3 ,e4 ,e5 ,e6 , e7 ,e8 ,e9 ,e10 , e11 ,e12 ,e13 ,e14 , e15 ,e16 ,e17 ,e18 , e19 ,e20 ,e21 ,e22 ;
    }
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct TypeForMaxStackOfDepth100
    {    
        TypeOfSize1024 a1 ;        
        TypeOfSize125 e1 ,e2 , e3 ,e4 ,e5 ,e6 , e7 ,e8 ,e9 ,e10 , e11 ,e12 ,e13 ,e14 , e15 ,e16 ,e17 ,e18 , e19 ,e20 ,e21 ,e22, e23 ,e24 ,e25 ,e26 , e27 ,e28 ,e29 ,e30 , e31 ,e32, e33 ,e34 ,e35 ,e36 , e37 ,e38 ,e39 ,e40 , e41 ,e42, e43 ,e44 ,e45 ,e46 , e47 ,e48 ,e49 ,e50 , e51 ,e52 ;    
    }
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct TypeForMaxStackOfDepth1000
    { 
        TypeOfSize125 a1 ;
        TypeOfSize22 e1 ,e2 , e3 ,e4 ,e5 ,e6 , e7 ,e8 ,e9 ,e10 , e11 ,e12 ,e13 ,e14 , e15 ,e16 ,e17 ,e18 , e19 ,e20,e21 ,e22, e23 ,e24 ,e25 ,e26 , e27 ,e28  ;
    }
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct TypeForMaxStackOfDepth3000
    {
        TypeOfSize22 a1 ;
        TypeOfSize5 e1 ,e2 , e3 ,e4 ,e5 ,e6 , e7 ,e8 ,e9 ,e10 , e11 ,e12,e13 ,e14 , e15 ,e16 ,e17 ,e18 , e19 ,e20,e21 ,e22, e23 ,e24 ,e25 ,e26 , e27 ,e28 ,e29 ,e30 , e31 ,e32, e33 ,e34 ,e35 ,e36   ;
    }
    public class TypeWithMemoryOnHeap
    {
        public TypeOfSize1024[] a ;
        public void Allocate()
        {
            a = new TypeOfSize1024[2000] ;
        }
        public void DeAllocate()
        {
            a = null ;
        }
    }
    public struct StructOrClass1
    {
        public int X;
    }
    public class StructOrClass2
    {
        public int X;
    }
    public struct StructOrClass3
    {
        public StructOrClass2 X ;
    }
    public enum FutureHusbandType : int
    {
        None = 0 ,
        HasBigNose=1  ,
        IsBald = 1 << 1 ,
        IsShort = 1 << 2 ,
    }
}
