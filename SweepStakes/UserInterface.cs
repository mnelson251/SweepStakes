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


        public void GreetingScreen()
        {
            Console.WriteLine("Welcome to devCodeCamp SweepStakes! \n");
            Console.WriteLine("We appreciate our members! That’s why we are offering you this \n" +
                "opportunity to enter for a chance to win! Once you give us your contact details, \n" +
                "we give you a number. After a few people have entered, and a little time goes by, we \n" +
                "will draw a number to determine the winner of the SweepStakes. Good luck, and thank \n" +
                "you for being a valued part of our family!\n");
            Console.ReadLine();
           
        }
        
        public void GetEntryDescion()
        {
            Console.WriteLine("Now you know how it works.\n Would you like to enter for a chance to Win? \n");
            Console.WriteLine("1) Yes, I want to win! \n 2) No, I don't want to win.");
            Console.WriteLine("Response:");
            MemberResponse = Console.ReadLine();
        }

       

        public void EnterTheContest(IContestant contestant)
        {
            if (MemberResponse == "1")
            {
                contestant.FetchCustomerInfomation();
            }
            else if (MemberResponse == "2")
            {
                PushTheSweepStakesAgain();
                RepromptResults(contestant);
            }
            else
            {
                Console.WriteLine("Sorry, not a vail input. Try again.");
                Console.ReadLine();
                EnterTheContest(contestant);
            }
        }

        public void AssignContestantRegistrationNumber()
        {

        }

        public void PushTheSweepStakesAgain()
        {
            Console.WriteLine("Are you sure you don't want to enter the contest? \n It's free to enter...");
            Console.WriteLine("1) You know what?! I will enter! \n 2) No, I'm sure I don't want a to enter for a chance to win.");
            Console.WriteLine("Response:");
            MemberRepromptResponse = Console.ReadLine();
        }

        public void RepromptResults(IContestant contestant)
        {
            if (MemberRepromptResponse == "1")
            {
                EnterTheContest(contestant);
            }
            else if (MemberRepromptResponse == "2")
            {
                Console.WriteLine("Sucks to Suck. See ya!");
                Console.ReadLine();
                return;
            }
            else
            {
                Console.WriteLine("Sorry, not a vail input. Try again.");
                Console.ReadLine();
                PushTheSweepStakesAgain();
                RepromptResults(contestant);
            }
        }
    }
}
