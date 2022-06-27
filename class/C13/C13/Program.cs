using System;
using System.Collections.Generic;

namespace C13
{
    public class Program
    {
        private static void Swap<_Type>(_Type[] nums, int i, int j)
        {
            _Type temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
        public delegate _RetType CompareDelegate<_Type, _RetType>(_Type a, _Type b);
        public bool Compare(int a, int b) => a<b;

        public static void Sort<_Type>(_Type[] nums, CompareDelegate<_Type, bool> cmp)
        {
            for(int i=0; i<nums.Length; i++)
                for (int j=i; j<nums.Length; j++)
                    if (cmp(nums[i], nums[j]))
                        Swap<_Type>(nums, i, j);
        }
        static void Main(string[] args)
        {
            
        }
    }
}
