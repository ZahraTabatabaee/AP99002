using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace C12.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            string first = @"..\..\..\..\..\C12\1.txt";
            string second = @"..\..\..\..\..\C12\2.txt";
            revese.ReverseTextFile(first, second);
            using (StreamReader reader = new StreamReader(first))
            {
                using (StreamReader writer = new StreamReader(second))
                {
                    string[] firstLines = File.ReadAllLines(first);
                    string[] secondLines = File.ReadAllLines(second);
                    int j = secondLines.Length-1;
                    for (int i = 0; i < firstLines.Length; i++)
                    {
                            Assert.AreEqual<string>(secondLines[i], firstLines[j]);
                            j--;
                    }
                    
                }
            }
            File.WriteAllText(@"..\..\..\..\..\C12\1.txt", System.String.Empty);
        }
    }
}
