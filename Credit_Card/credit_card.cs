using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credit_Card
{
    class credit_card
    {
       
            public decimal AnnualSalary { get; set; }
            public int RentYears { get; set; }
            public int EmployedYears { get; set; }
            public int LivingYears { get; set; }

            public credit_card(decimal annualSalary, int rentYears, int employedYears, int livingYears)
            {
                AnnualSalary = annualSalary;
                RentYears = rentYears;
                EmployedYears = employedYears;
                LivingYears = livingYears;
            }

            public bool IsEligibleForCreditCard()
            {
                if (AnnualSalary >= 25000 ||
                    (AnnualSalary >= 20000 && RentYears * 4 < AnnualSalary) ||
                    (AnnualSalary >= 15000 && LivingYears >= 5) ||
                    (AnnualSalary >= 10000 && EmployedYears >= 3 && LivingYears >= 5))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        
    }
}
