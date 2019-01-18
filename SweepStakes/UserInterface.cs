using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class UserInterface // As a user interface, shouldn't be doing logic, just giving/getting info
    {
        public string MemberResponse;
        public string MemberRepromptResponse;
        public Contestant _contestant;


        public void GreetingScreen(SweepStakes SweepStakes)
        {
            Console.WriteLine("Welcome to " + SweepStakes.sweepStakesName + " SweepStakes! \n");
            Console.WriteLine("We appreciate our members! That’s why we are offering you this \n" +
                "opportunity to enter for a chance to win! Once you give us your contact details, \n" +
                "we give you a number. After a few people have entered, and a little time goes by, we \n" +
                "will draw a number to determine the winner of the SweepStakes. Good luck, and thank \n" +
                "you for being a valued part of our family!\n");
            Console.ReadLine();
        }
        
        public void GetEntryDescion()
        {
            Console.WriteLine("Now you know how it works.\nWould you like to enter for a chance to Win?\n");
            Console.WriteLine("1) Yes, I want to win!\n2) No, I don't want to win.");
            Console.WriteLine("Response:");
            MemberResponse = Console.ReadLine();
            Console.Clear();
        }
        
        public void PushTheSweepStakesAgain()
        {
            Console.WriteLine("Are you sure you don't want to enter the contest?\n It's free to enter...");
            Console.WriteLine("1) You know what?! I will enter!");
            Console.WriteLine("2) No, I'm sure I don't want a to enter for a chance to win.");
            Console.WriteLine("Response:");
            MemberRepromptResponse = Console.ReadLine();
            Console.Clear();
        }

        public void EnterTheContest()
        {
            _contestant = new Contestant();

            if (MemberResponse == "1")
            {
                _contestant.FetchContestantInfomation();
            }
            else if (MemberResponse == "2")
            {
                PushTheSweepStakesAgain();
                RepromptResults();
            }
        }

        public void RepromptResults()
        {
            if (MemberRepromptResponse == "1")
            {
                EnterTheContest();
            }
            else if (MemberRepromptResponse == "2")
            {
                Console.WriteLine("Sucks to Suck. See ya!");
                Console.ReadLine();
                return;
            } 
        }




    }
}
