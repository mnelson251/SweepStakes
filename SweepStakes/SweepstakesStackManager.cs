using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepstakesStackManager : ISweepStakesManager
    {

        public Stack<SweepStakes> SweepStakesStack = new Stack<SweepStakes>();

        public void InsertSweepStakes(SweepStakes SweepStakes)
        {
            SweepStakesStack.Push(SweepStakes);
        }

        public SweepStakes GetSweepStakes()
        {
            return SweepStakesStack.Pop();
        }

    }
}
