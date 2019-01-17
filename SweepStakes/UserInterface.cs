using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class UserInterface
    {
        public string MemberResponse;


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
        
        public void EnterInformationOption()
        {
            Console.WriteLine("Now you know how it works.\n Would you like to enter for a chance to Win? \n");
            Console.WriteLine("1) Yes, I want to win! \n 2) No, I don't want to win.");
            Console.WriteLine("Response:");
            MemberResponse = Console.ReadLine();
        }

        public void EnterTheConstest()
        {
            IContestant.FetchCustomerInfomation();
        }



    }
}
