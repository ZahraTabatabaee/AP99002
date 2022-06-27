using System;
using System.Linq;

namespace E2.Q4
{
    public class Country : IVoter
    {
        private State[] _state;

        public Country(string name, State[] states)
        {
            _state = states;
        }
        /// <summary>
        /// generating vote result for the entire country by summing all the vote results of the states located in  the country
        /// and caaling each state's vote function which itself calls the located cities' vote function and so on (call hierarchy)
        /// </summary>
        /// <param name="issue"></param>
        public VoteResult Vote(string issue)
        {
            int yesCount = 0, noCount=0, whiteCount=0;
            VoteResult p = new VoteResult(issue , 0 ,0 ,0);
            foreach( var s in this._state)
            {
                p = s.Vote(issue);
                yesCount += p.YesCount;
                noCount += p.NoCount;
                whiteCount += p.WhiteCount;
            }
            return new VoteResult(issue , yesCount , noCount ,whiteCount);
        }
    }
}