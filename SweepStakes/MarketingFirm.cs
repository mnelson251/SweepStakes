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
            SweepStakes.RunThisSweepStakes( mainMenu);
            mainMenu._contestant.RegistrationNumber = SweepStakes._RegistrationNumber;
            SweepStakes.RegisterContestant(mainMenu._contestant);

            //string SweepStakesWinner = SweepStakes.PickWinner();
            //SweepStakes.PrintContestantInfomation(SweepStakes.value);
            
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
