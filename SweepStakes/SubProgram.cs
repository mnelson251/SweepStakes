using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SubProgram
    {
        SweepstakesStackManager Stack_Type = new SweepstakesStackManager();
        SweepstakesQueueManager Queue_Type = new SweepstakesQueueManager();
        public MarketingFirm marketing;
        
        public SubProgram()
        {
           
        }

        public MarketingFirm SelectManagerType()
        {
            String Selected_Manager;
            Console.WriteLine("Welcome.\n");
        here:
            Console.WriteLine("How would you like to manage your data: \n1) {0} \n2) {1}", "STACK data type", "QUEUE data type");
            Console.WriteLine();
            Selected_Manager = Console.ReadLine();
            Console.Clear();
            if (Selected_Manager == "1")
            {
                marketing = new MarketingFirm(Stack_Type);
                return marketing;
            }
            if (Selected_Manager == "2")
            {
                marketing = new MarketingFirm(Queue_Type);
                return marketing;
            }
            else
            {
                Console.WriteLine("Sorry, invalid entry!");
                Console.ReadLine();
                Console.Clear();
                goto here;
            }
        }
       
    }
}
