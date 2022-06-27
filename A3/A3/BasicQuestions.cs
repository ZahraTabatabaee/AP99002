using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3
{
	public class Human : IHasAge
	{
		public Human(string name , int age)
		{
			this.name = name ;
			this.age = age ;
		}
		public string Name 
		{
			get { return this.name; } 
			set { this.name = value; }  
		}
		public int age ;
		public string name ;

        public int GetAge()
        {
            return age ;
        }
    }
	public class BasicQuestions
	{
		public static int OddSum(int[] nums)
		{
			int sum = 0 ;
			for(int i = 0 ; i < nums.Length ; i++)
			{
				if(nums[i]%2==1)
					sum += nums[i];
			}
			return sum ;
		}
		public static void  Swap<_type>(ref _type a , ref _type b)	
		{
			_type c;
			c = a ;
			a = b ;
			b = c ;		
		}
		public static void AssignPi(out double d)
		{
			d = Math.PI ;
		}
		public static void Square(ref int d)
		{
			d = d*d ;
		}
		public static void Append(ref int[] a , int b)
		{
			int[] copy = new int[a.Length+1];
			int idx = 0 ;
			for(int i = 0 ; i < a.Length ; i++)
			{
				copy[i] = a[i];
				idx++;
			}
			copy[idx] = b ;
			a = copy ;
		}
		public static void AbsArray(ref int[] a)
		{
			for(int i = 0 ; i < a.Length ; i++)
			{
				if(a[i]<0)
				{
					a[i] = -a[i];
				}
			}		
		}
		public static void ArrayElementSwap(ref int[] a, ref int[] b)
		{
			for(int i = 0 ; i < a.Length ; i++)
			{
				Swap<int>(ref a[i], ref b[i]);
			}
		}
		public static void ArraySwap(ref int[] a, ref int[] b)
		{
			// int m = a.Length;
			// Array.Resize(ref a,b.Length);
			// ArrayElementSwap(ref a, ref b);
			// Array.Resize(ref b,m);
			int[] tmp = a ;
			a = b ;
			b = tmp;
		}
	}
}
