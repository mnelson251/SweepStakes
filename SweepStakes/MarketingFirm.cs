using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class MarketingFirm
    {

        public string name;
        public SweepStakes SweepStakes;
        public ISweepStakesManager manager;
        public UserInterface mainMenu;

        public MarketingFirm(ISweepStakesManager mySweepStakesManager )
        {
            this.manager = mySweepStakesManager;
        }

        public void RunSweepStakes()
        {
            GetSweepStakes();
            mainMenu = new UserInterface();
            SweepStakes.RunThisSweepStakes(mainMenu);
            mainMenu._contestant.RegistrationNumber = SweepStakes._RegistrationNumber;
            SweepStakes.RegisterContestant(mainMenu._contestant); 
        }

        public SweepStakes GetSweepStakes()
        {
            SweepStakes = new SweepStakes(name);
            return SweepStakes;
        }



    }
}
