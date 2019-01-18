using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepstakesQueueManager : ISweepStakesManager
    {

        Queue<SweepStakes> SweepStakesQueue = new Queue<SweepStakes>();


        public void InsertSweepStakes(SweepStakes SweepStakes)
        {
            SweepStakesQueue.Enqueue(SweepStakes);
        }

        public SweepStakes GetSweepStakes()
        {
            return SweepStakesQueue.Dequeue();
        }




    }
}
