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
        public Contestant value;
        public Contestant contestant = new Contestant();
        Dictionary<int, Contestant> sSDictionary = new Dictionary<int, Contestant>();
        
        public SweepStakes(string sweepStakesName)
        {
            NameThisSweepStakes();
            sweepStakesName = this.sweepStakesName;   
        }

        public void NameThisSweepStakes()
        {
            Console.WriteLine("Please name this SweepStakes.");
            sweepStakesName = Console.ReadLine();
            Console.Clear();
        }

        public void RunThisSweepStakes(UserInterface mainMenu, SweepStakes sweep)
        {
            GenerateRegistrationNumber();
            mainMenu.GreetingScreen(sweep);
            mainMenu.GetEntryDescion();
            mainMenu.EnterTheContest();
        }
        
        public void GenerateRegistrationNumber() // don't need to return, but need to incriment everytime obj is created
        {
            GeneratedRegistrationNumber++;
            _RegistrationNumber = GeneratedRegistrationNumber;
        }
        
        public void RegisterContestant (Contestant contestant) // where this is called, must create contestant obj
        {
            contestant.RegistrationNumber = _RegistrationNumber; // RegNum generated in this class
            sSDictionary.Add(contestant.RegistrationNumber, contestant);
        }

        public string PickWinner()
        {
            int RandomWinnerKey;
            string Winner;
            Random rnd = new Random();
            RandomWinnerKey = rnd.Next(sSDictionary.Keys.Min(), sSDictionary.Keys.Max());
            value = sSDictionary[RandomWinnerKey];
            Winner = value.FullName;
            return Winner;
        }

        public void PrintContestantInfomation()
        { 
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(value.FullName);
            sb.AppendLine(value.EmailAddress);
            Console.WriteLine("The Winner is:\n");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
        
    }
}
