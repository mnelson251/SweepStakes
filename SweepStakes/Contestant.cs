using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Contestant : IContestant
    {

        public string FirstName;
        public string LastName;
        public string EmailAddress;
        public int RegistrationNumber; // this needs to auto populate when contestant registers for sweepstakes

        public Contestant()
        {
            GenerateRegistrationNumber();
        }

        public void FetchCustomerInfomation()
        {
            ContestantEnterFirstName();
            ContestantEnterLastName();
            ContestantEnterEmail();
        }

        public void ContestantEnterFirstName()
        {
            Console.WriteLine("Please enter your first name.\n");
            FirstName = Console.ReadLine();
        }

        public void ContestantEnterLastName()
        {
            Console.WriteLine("Right on " + FirstName + ". Now, if you could please enter your last name.\n");
            LastName = Console.ReadLine();
        }

        public void ContestantEnterEmail()
        {
            Console.WriteLine("Okay! We have your full name now.\n Could you please enter your email adress, " + FirstName);
            EmailAddress = Console.ReadLine();
        }

        public int GenerateRegistrationNumber()
        {
            RegistrationNumber = 000;
            RegistrationNumber++;
            return RegistrationNumber;
        }











    }
}
