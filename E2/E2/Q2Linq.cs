
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Q2ChildMortailityStats
{
    public Q2ChildMortailityStats(string filePath)
    {    
        Path = filePath ;    
    }




    public int Q21_HighestNeoNatalMortalityYear => throw new NotImplementedException();
    // {
    //     get{
    //         File.ReadAllLines(Path)   
    //         .Skip(2)         
    //         .Select(s => {
    //             var toks = s.Split(',').Select(t => t.Trim('"')).ToArray();
    //             return new  {
    //                 _Year = Int32.Parse(toks[1]),
    //                 _Rate = Convert.ToDouble(toks[2])
    //             };})
    //             .GroupBy(b => b._Year)
    //             .GroupJoin()
    //     }
    // }
    public (string country, int year) Q22_HighestDifferenceBetweenMaleAndFemale => throw new NotImplementedException();
    public string Q23_CountryWithHighestNeoNatalImprovement => throw new NotImplementedException();

    public string Path { get; }
}