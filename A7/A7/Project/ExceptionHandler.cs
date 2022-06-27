using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace A7
{
    public class ExceptionHandler
    {
        public string ErrorMsg { get; set; }
        public readonly bool DoNotThrow;
        private string _Input;

        public string Input
        {
            get
            {
                try
                {
                    if (_Input.Length < 50)
                        return _Input;
                }
                catch
                {
                    if (!DoNotThrow)
                        throw;
                    ErrorMsg = "Caught exception in GetMethod";
                }
                return null;
            }
            set
            {
                try
                {
                    if (value.Length < 50)
                        _Input = value;
                }
                catch
                {
                    if (!DoNotThrow)
                        throw;
                    ErrorMsg = "Caught exception in SetMethod";
                }
            }
        }


        public ExceptionHandler(
            string input,
            bool causeExceptionInConstructor,
            bool doNotThrow=false)
        {
            DoNotThrow = doNotThrow;
            this._Input = input;
            try
            {
                if (causeExceptionInConstructor)
                {

                    string test = null;
                    if (test.Length > 0)
                        Console.WriteLine("test");
                }
            }
            catch
            {
                if (!DoNotThrow)
                    throw;
                ErrorMsg = "Caught exception in constructor";
            }
        }

        public void OverflowExceptionMethod()
        {
            #region TODO
            try
            {
                if (int.Parse(Input)==10)
                {
                    System.Console.WriteLine(Input);
                }
                else
                {
                    string str = "8080808080808080";
                    int res = int.Parse(str);
                }

            }
            catch(OverflowException e)
            {
                if (!DoNotThrow)
                    throw;
                ErrorMsg = $"Caught exception {e.GetType()}";
            }
            #endregion
        }

        public void FormatExceptionMethod()
        {
            try
            {
                int i = int.Parse(Input);
            }
            catch(FormatException e)
            {
                if (!DoNotThrow)
                    throw;
                ErrorMsg = $"Caught exception {e.GetType()}";
            }
        }

        public void FileNotFoundExceptionMethod()
        {
            #region TODO
            try
            {
                if(int.Parse(Input)==10)
                    File.ReadLines("..\\..\\..\\..\\..\\A7\\A7\\a.txt");
                else
                    File.ReadLines("..\\..\\..\\..\\..\\A7\\A7\\b.txt");
            }
            catch(FileNotFoundException e)
            {
                if (!DoNotThrow)
                    throw;
                ErrorMsg = $"Caught exception {e.GetType()}";
            }
            #endregion
        }

        public void IndexOutOfRangeExceptionMethod()
        {
            #region TODO
            try
            {
                int[] array = new int[1];
                System.Console.WriteLine(array[int.Parse(Input)]); 

            }
            catch(IndexOutOfRangeException e)
            {
                if (!DoNotThrow)
                    throw;
                ErrorMsg = $"Caught exception {e.GetType()}";
            }
            #endregion
        }

        public void OutOfMemoryExceptionMethod()
        {
            #region TODO
            try
            {
                if (int.Parse(Input)==10)
                {
                    System.Console.WriteLine(Input);
                }
                else
                {
                    StringBuilder sb = new StringBuilder(int.Parse(Input));
                    sb.Append("zahrasadat");
                    sb.Insert(0,"zahrasadat", 1);
                }

            }
            catch(OutOfMemoryException e)
            {
                if (!DoNotThrow)
                    throw;
                ErrorMsg = $"Caught exception {e.GetType()}";
            }
            #endregion
        }

        public void MultiExceptionMethod()
        {
            #region TODO
            try
            {
                if (int.Parse(Input)==0)
                {
                    System.Console.WriteLine(Input);
                }
                else
                {
                    StringBuilder sb = new StringBuilder(int.Parse(Input));
                    sb.Append("zahrasadat");
                    sb.Insert(0,"zahrasadat", 1);
                    string[] array = new string[1];
                    System.Console.WriteLine(array[int.Parse(Input)]); 
                }

            }
            catch(OutOfMemoryException e)
            {
                if (!DoNotThrow)
                    throw;
                ErrorMsg = $"Caught exception {e.GetType()}";
            }
            catch(IndexOutOfRangeException e)
            {
                if (!DoNotThrow)
                    throw;
                ErrorMsg = $"Caught exception {e.GetType()}";
            }
            #endregion
        }

        public static void ThrowIfOdd(int n)
        {
            #region TODO
            if(n%2==1)
                throw new InvalidDataException();
            
            #endregion
        }

        public string FinallyBlockStringOut;

        public int FinallyBlockMethod(string s)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter swr = new StringWriter(sb);
            try
            {
                #region TODO
                if (s == "beautiful")
                    swr.Write($"InTryBlock:{s}:9:DoneWriting");
                if (s == "ugly")
                {
                    swr.Write($"InTryBlock:");
                    return 0 ;
                }
                if (s == null)
                {
                    swr.Write($"InTryBlock:");
                    throw new NullReferenceException();
                }

                #endregion
            }
            catch (NullReferenceException nre)
            {
                #region TODO
                swr.Write($":{nre.Message}");
                if (!DoNotThrow)
                    throw;
                #endregion
            }
            finally
            {
                swr.Write(":InFinallyBlock");
                swr.Dispose();
                FinallyBlockStringOut = sb.ToString();
            }
            FinallyBlockStringOut += ":EndOfMethod";
            return 0 ;
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void NestedMethods()
        {
            MethodA();
        }
        public static void MethodA()
        {
            MethodB();
        }

        private static void MethodB()
        {
            MethodC();
        }

        private static void MethodC()
        {
            MethodD();
        }

        private static void MethodD()
        {
            throw new NotImplementedException();
        }
        #region TODO
        #endregion
    }
}
