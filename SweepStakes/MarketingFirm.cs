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
        public Contestant contestant;
        public UserInterface mainMenu;

        public MarketingFirm()
        {

        }

        public void Run()
        {
            GetSweepStakes();
            contestant = new Contestant();
            mainMenu = new UserInterface();
            contestant.RegistrationNumber = SweepStakes._RegistrationNumber;
            SweepStakes.RunThisSweepStakes( mainMenu, contestant);
            SweepStakes.RegisterContestant(contestant);



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
