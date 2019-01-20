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
        public int NumberOfContestantsToLoop;
        public string MarketingResponse;
        public string PrintResponse;

        public MarketingFirm(ISweepStakesManager mySweepStakesManager )
        {
            this.manager = mySweepStakesManager;
            //RunSweepStakes();
        }

        public void RunSweepStakes()
        {
            GetSweepStakes();
            mainMenu = new UserInterface();
            NumberOfContestants();
            for (int i = 0; i < NumberOfContestantsToLoop; i++) // need more than one to pick winner
            {
                Console.WriteLine("Contestant Number " + (i +1));
                SweepStakes.RunThisSweepStakes(mainMenu, SweepStakes);
                SweepStakes.RegisterContestant(mainMenu._contestant);
            }
            TimeToChooseAWinner(SweepStakes);
            ChooseToPrintInfomation(SweepStakes);
        }

        public SweepStakes GetSweepStakes()
        {
            SweepStakes = new SweepStakes(name);
            return SweepStakes;
        }

        public void NumberOfContestants()
        {
            Console.WriteLine("How many contestants would you like to enter the sweepstakes?");
            NumberOfContestantsToLoop = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
        }

        public void TimeToChooseAWinner(SweepStakes SweepStakes)
        {
            here:
            Console.WriteLine("Do you want to pick a winner yet?");
            Console.WriteLine("YES or NO");
            MarketingResponse = Console.ReadLine().ToLower();
            if (MarketingResponse == "yes")
            {
                SweepStakes.PickWinner();
                Console.Clear();
            }
            else if (MarketingResponse == "no")
            {
                Console.WriteLine("Pick a winner already");
                Console.ReadLine();
                Console.Clear();
                TimeToChooseAWinner(SweepStakes);
            }
            else
            {
                Console.WriteLine("Invalid entry. DO YOUR JOB!");
                goto here;
            }
        }

        public void ChooseToPrintInfomation(SweepStakes sweepstakes)
        {
            Console.WriteLine("Would you like to print the winners infromation to the console?");
            Console.WriteLine("YES or NO");
            PrintResponse = Console.ReadLine().ToLower();
            if (PrintResponse == "yes")
            {
                sweepstakes.PrintContestantInfomation();
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("END OF PROGRAM");
                Console.ReadLine();
                return;
            }

        }

    }
}
