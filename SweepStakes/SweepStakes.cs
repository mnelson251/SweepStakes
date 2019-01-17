using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepStakes
    {
        
        public string sweepStakesName;
        public int _RegistrationNumber;
        public int GeneratedRegistrationNumber = 000;
       
        Dictionary<int, string> RegisteredContestantsDictionary = new Dictionary<int, string>();
        UserInterface MainMenu = new UserInterface();

        public SweepStakes(string sweepStakesName)
        {
            NameThisSweepStakes();
            this.sweepStakesName = sweepStakesName;   
        }

        public string NameThisSweepStakes()
        {
            Console.WriteLine("Please name this SweepStakes.");
            sweepStakesName = Console.ReadLine();
            Console.Clear();
            return sweepStakesName;
        }

        public void RunThisSweepStakes(UserInterface mainMenu, Contestant contestant)
        {
            GenerateRegistrationNumber();
            mainMenu.GreetingScreen();
            mainMenu.GetEntryDescion();
            mainMenu.EnterTheContest(contestant);
        }


        public void GenerateRegistrationNumber() // don't need to return, but need to incriment everytime obj is created
        {
            GeneratedRegistrationNumber++;
            _RegistrationNumber = GeneratedRegistrationNumber;
        }

        
        public void RegisterContestant (Contestant contestant) // where this is called, must create contestant obj
        {
            contestant.RegistrationNumber = _RegistrationNumber; // RegNum generated in this class
            RegisteredContestantsDictionary.Add(contestant.RegistrationNumber, contestant.FullName);
        }

        //public string PickWinner()
        //{
        //    string Winner;
            
        //    return Winner;
        //}

        public void PrintContestantInfomation(Contestant contestant, Dictionary<int, string> RegisteredContestantDictionary) // create 
        { // create a switch statment that access the dictionary (through built-in properties) and print final value to console
           
           
        }

        



    }
}
