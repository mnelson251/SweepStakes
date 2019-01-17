using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public interface IContestant
    {
        void FetchCustomerInfomation();

        void ContestantEnterFirstName();

        void ContestantEnterLastName();
        
        void ContestantEnterEmail();

        int GenerateRegistrationNumber();

    }

}
