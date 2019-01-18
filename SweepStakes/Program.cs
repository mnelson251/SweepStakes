using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Program
    {
        static void Main(string[] args)
        {

            SweepstakesStackManager sweepstakesStackManager = new SweepstakesStackManager();
            SweepstakesQueueManager sweepstakesQueueManager = new SweepstakesQueueManager();
            MarketingFirm marketing = new MarketingFirm(sweepstakesQueueManager);
            marketing.RunSweepStakes();

            //string SweepStakesWinner = SweepStakes.PickWinner();
            //SweepStakes.PrintContestantInfomation(SweepStakes.value);



        }
    }
}
