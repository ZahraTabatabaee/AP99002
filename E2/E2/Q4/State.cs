using System;
using System.Linq;

namespace E2.Q4
{
    public class State : IVoter
    {
        private City[] _city;

        public State(string name, City[] city)
        {
            _city = city ;
        }
        /// <summary>
        /// generating vote result for a state by summing all the vote results of the cities located in  this state
        /// and calling each city's vote function
        /// </summary>
        public VoteResult Vote(string issue)
        {
            int yesCount = 0, noCount=0, whiteCount=0;
            VoteResult p = new VoteResult(issue , 0 ,0 ,0);
            foreach( var c in this._city)
            {
                p = c.Vote(issue);
                yesCount += p.YesCount;
                noCount += p.NoCount;
                whiteCount += p.WhiteCount;
            }
            return new VoteResult(issue , yesCount , noCount ,whiteCount);
        }
    }
}