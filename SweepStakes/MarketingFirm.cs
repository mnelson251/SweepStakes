using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class MarketingFirm : ISweepStakesManager
    {

        public string name;
        public SweepStakes SweepStakes;
        
        public UserInterface mainMenu;

        public MarketingFirm()
        {

        }

        public void Run()
        {
            GetSweepStakes();
            mainMenu = new UserInterface();
            mainMenu._contestant.RegistrationNumber = SweepStakes._RegistrationNumber;
            SweepStakes.RunThisSweepStakes( mainMenu, mainMenu._contestant);
            SweepStakes.RegisterContestant(mainMenu._contestant);
        }

        public void InsertSweepStakes(SweepStakes SweepStakes)
        {

        }

        public SweepStakes GetSweepStakes()
        {
            SweepStakes = new SweepStakes(name);
            return SweepStakes;
        }



    }
}
