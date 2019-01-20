using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Contestant
    {
        public string FirstName;
        public string LastName;
        public string FullName;
        public string EmailAddress;
        public int RegistrationNumber; // this needs to auto populate when contestant registers for sweepstakes

        public Contestant()
        {
           
        }

        public void FetchContestantInfomation() // Encapsulating my methods, keeping it cle
        {
            ContestantEnterFirstName();
            ContestantEnterLastName();
            ContestantEnterEmail();
            ConcatNamesToMakeFullName();
        }

        public void ContestantEnterFirstName()
        {
            Console.WriteLine("Please enter your first name.");
            FirstName = Console.ReadLine();
        }

        public void ContestantEnterLastName()
        {
            Console.WriteLine("\nRight on " + FirstName + ". Now, if you could please enter your last name.");
            LastName = Console.ReadLine();
        }

        public void ContestantEnterEmail()
        {
            Console.WriteLine("\nOkay! We have your full name now.\nCould you please enter your email adress, " + FirstName);
            EmailAddress = Console.ReadLine();
            Console.Clear();
        }
        
        public string ConcatNamesToMakeFullName()
        {
            FullName = FirstName + " " + LastName;
            return FullName;
        }
        
    }
}
