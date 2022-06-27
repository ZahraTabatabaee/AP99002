// using System;
// using System.IO;
// using System.Linq;
// using System.Collections.Generic;

// namespace C22
// {
//     public record WordCount(string Word, int Count);

//     // public class WordCount
//     // {
//     //     public int Count{get; init;}
//     //     public string Word{ get; init;}
//     //     public WordCount(string word, int count)
//     //     {
//     //         this.Count = count;
//     //         this.Word = word;
//     //     }
//     // }

//     public static class Ext
//     {
//         public static IEnumerable<WordCount> GetHistogram(this string fileName, string country) =>
//                 File.ReadAllLines(fileName)
//                 .Select(l => l.ToLower())
//                 .Where(l => l.Contains(country))
//                 .SelectMany(l => l.Split(new char[]{' ', '"'}, StringSplitOptions.RemoveEmptyEntries))
//                 .Select(w => w.Trim(new char[]{',', '.', ';', ':'}))
//                 .GroupBy(w => w)
//                 .Select(g => new WordCount(g.Key, g.Count()))
//                 .OrderByDescending(d => d.Count);

//     }

//     class Program
//     {
//         static string MakeString((string str, int cnt) w)
//         {
//             return $"{w.str} => {w.cnt}";
//         }

//         static string MakeString(WordCount w)
//         {
//             return $"{w.Word} => {w.Count}";
//         }

//         static void MainTODO(string[] args)
//         {
//             // Find the year each country's children per women rate dropped the most compared to previous year
//             // The result should have (country, rate, previous year, current year, diff)
//             // ordered by "diff"
//         }


//         static void Main554(string[] args)
//         {
//             var israelData = "TweetText.txt".GetHistogram("israel");
//             var iranData = "TweetText.txt".GetHistogram("iran");


//             iranData.Join(israelData, ird => ird.Word, isd => isd.Word, 
//                                       (ird,isd) => (isd.Word, irCnt: ird.Count, isCnt: isd.Count))
//                     .OrderBy(d => d.irCnt)
//                     .Take(50)
//                     .Select(d => d.ToString())
//                     .ToList()
//                     .ForEach(Console.WriteLine);
//         }


//         static void Main123(string[] args)
//         {
//             var israelData = "TweetText.txt".GetHistogram("israel");
//             var iranData = "TweetText.txt".GetHistogram("iran");

//             var israelDic = israelData.ToDictionary(d => d.Word);
//             var iranDic = iranData.ToDictionary(d => d.Word);

//             israelData.Take(30).Zip(iranData, (dis, dir) => 
//                         (dis.Word, dis.Count, iranDic.ContainsKey(dis.Word)? iranDic[dis.Word].Count: 0))
//                 .ToList()
//                 .ForEach(l => System.Console.WriteLine(l));

//             System.Console.WriteLine("------------");

//             iranData.Take(30).Zip(israelData, (dir, dis) => 
//                         (dir.Word, dir.Count, israelDic.ContainsKey(dis.Word)? israelDic[dis.Word].Count: 0))
//                 .ToList()
//                 .ForEach(l => System.Console.WriteLine(l));

//         }


//         static void Main4(string[] args)
//         {
//             var israelData = "TweetText.txt".GetHistogram("israel").Take(20);
//             var iranData = "TweetText.txt".GetHistogram("iran").Take(20);

//             israelData.Zip(iranData, (dis, dir) => (dis.Word, dis.Count, dir.Word, dir.Count))
//                 .ToList()
//                 .ForEach(l => System.Console.WriteLine(l));
//         }

//         static void Main(string[] args)
//         {
//             File.ReadAllLines("TweetText.txt")
//                 .Select(l => l.ToLower())
//                 .Where(l => l.Contains("israel"))
//                 .SelectMany(l => l.Split(new char[]{' ', '"'}, StringSplitOptions.RemoveEmptyEntries))
//                 .Select(w => w.Trim(new char[]{',', '.', ';', ':'}))
//                 .GroupBy(w => w)
//                 .Select(g => new WordCount(g.Key, g.Count()))
//                 .OrderByDescending(d => d.Count)
//                 .Select(d => MakeString(d))
//                 .Take(30)
//                 .ToList()
//                 .ForEach(l => System.Console.WriteLine(l));
//         }
//         // .Distinct()


//     }
// }
