using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWnumber6
{
    class BankAccount0
    {
        public double BankAccountID0;
        public double BankAccountBalance0;
        public string BankAccountType0;
    }
    
    public class BankAccount1
    {
        private static double NewID = 1;
        public static void 
            IncreaseNewID()
        {
            NewID++;
        }
        public double BankAccountID1;
        public double BankAccountBalance1;
        public string BankAccountType1;
    }
}

    
