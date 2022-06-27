using System;
using System.Linq;

namespace E2.Q4
{
    public class City : IVoter
    {
        Person[] _Peaple = new Person[]{};
        public City(string name, Person[] people)
        {
            _Peaple = people ;
        }
        /// <summary>
        /// shows the entire vote result of a city by calculating the sum of all people's vote who live in this city
        /// by calling each person's vote function
        /// </summary>
        public VoteResult Vote(string issue)
        {
            int yesCount = 0, noCount=0, whiteCount=0;
            VoteResult p = new VoteResult(issue , 0 ,0 ,0);
            foreach( var person in this._Peaple)
            {
                p = person.Vote(issue);
                yesCount += p.YesCount;
                noCount += p.NoCount;
                whiteCount += p.WhiteCount;
            }
            return new VoteResult(issue , yesCount , noCount ,whiteCount);
        
        }
    }
}