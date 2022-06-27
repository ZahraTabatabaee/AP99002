using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace E1
{
    public class Matrix<_Type> :
        ICalculable<Matrix<_Type>>,
        IEquatable<Matrix<_Type>>
        where
            _Type : ICalculable<_Type>, IEquatable<_Type>
    {
        private _Type[,] Data;

        public Matrix(int a , int b)
        {
            Data = new _Type[a,b];
            row = a ;
            column = b ;
        }
        private int row ;
        private int column ;
        public void SetData(int a, int b , _Type d )
        {
            Data[a,b] = d ;
        }
        public _Type GetData(int a , int b)
        {
            return Data[a,b];
        }
        public int RowCount
        {
            get{
                return row ;
            }
        }
        // public _Type Rows
        // {
        //     get
        //     {
        //         _Type[] array = new _Type[]{};
        //         for(int i = 0 ; i < this.RowCount ; i++)
        //         {
                    
        //         }
        //     }
        // }
        public int ColumnCount
        {
            get{
                return column ;
            }
        }
        public Matrix<_Type> PlusIdentity
        {
            get
            {
                w = z.PlusIdentity ;
                z.Reset();
                Matrix<_Type> _new = new Matrix<_Type>(this.RowCount,this.ColumnCount);
                for(int i = 0 ; i < this.RowCount ; i++)
                {
                    for(int j = 0 ; j < this.ColumnCount ; j++)
                    {
                        if(i==j)
                            _new.SetData(i,j,w);
                        else
                            _new.SetData(i,j,z);
                    }
                }
                return _new ;
            }
        }
        
        public List<_Type> getOneRow(Matrix<_Type> m, int row)
        {
            List<_Type> r = new List<_Type>{};
            for(int i = 0 ; i < m.ColumnCount ; i++)
            {
                r.Add(m.Data[row,i]);
            }
            return r;
        }
        private string result = null ;
        public override string ToString()
        {
            result += $"{this.RowCount} { this.ColumnCount}" + "\n";
            for(int i = 0 ; i < this.RowCount ; i++)
            {
                result += $"{String.Join(" ", getOneRow(this, i))}" + "\n";
            }
            return result ;
        }

        public Matrix<_Type> NegIdentity
        {
            get
            {
                w = z.NegIdentity ;
                z.Reset();
                Matrix<_Type> _new = new Matrix<_Type>(this.RowCount,this.ColumnCount);
                for(int i = 0 ; i < this.RowCount ; i++)
                {
                    for(int j = 0 ; j < this.ColumnCount ; j++)
                    {
                        if(i==j)
                            _new.SetData(i,j,w);
                        else
                            _new.SetData(i,j,z);
                    }
                }
                return _new ;
            }
        }

        public Matrix<_Type> AddWith(Matrix<_Type> other)
        {
            Matrix<_Type> _new = new Matrix<_Type>(other.RowCount,other.ColumnCount);
            for(int i = 0 ; i < other.RowCount ; i++)
            {
                for(int j = 0 ; j < other.ColumnCount ; j++)
                {
                    _new.SetData(i,j,this.GetData(i,j).AddWith(other.GetData(i,j)) );
                }
            }
            return _new ;
        }

        public Matrix<_Type> Clone()
        {
            Matrix<_Type> _new = new Matrix<_Type>(this.RowCount,this.ColumnCount);
            for(int i = 0 ; i < this.RowCount ; i++)
            {
                for(int j = 0 ; j < this.ColumnCount ; j++)
                {
                    _new.SetData(i,j,this.GetData(i,j));
                }
            }
            return _new ;
        }

        public bool Equals(Matrix<_Type> other)
        {
            for(int i = 0 ; i < this.RowCount ; i++)
            {
                for(int j = 0 ; j < this.ColumnCount ; j++)
                {
                    if(!this.GetData(i,j).Equals(other.GetData(i,j)))
                    {
                        return false ;
                    }
                }
            }
            return true ;
        }

        public void LoadFromStr(string str)
        {
            throw new NotImplementedException();
        }

        public Matrix<_Type> MultiplyBy(Matrix<_Type> other)
        {
            Matrix<_Type> _new = new Matrix<_Type>(other.RowCount,other.RowCount);
            int idx =1 ;
            for(int i = 1 ; i <= other.RowCount ; i++)
            {
                for(int j = 1 ; j <= other.ColumnCount ; j++)
                {
                    f.AddWith(this.GetData(i,j).MultiplyBy(other.GetData(j,i)));
                }
            _new.SetData(i,idx,f );
            idx++;
            }
            return _new ;
        }
        private _Type f ;
        public void Reset()
        {
            z.Reset(); 
            for(int i = 0 ; i < this.RowCount ; i++)
            {
                for(int j = 0 ; j < this.ColumnCount ; j++)
                {
                    this.SetData(i,j,z);
                }
            }
        }
        private _Type z ;
        private _Type w ;
        public void RndSet()
        {
            z.RndSet(); 
            for(int i = 0 ; i < this.RowCount ; i++)
            {
                for(int j = 0 ; j < this.ColumnCount ; j++)
                {
                    this.SetData(i,j,z);
                }
            }
        }

        public void Set(Matrix<_Type> o)
        {
            throw new NotImplementedException();
        }
    }
}
