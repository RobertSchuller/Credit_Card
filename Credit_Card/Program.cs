/*Write a program that will process ten individual's application numbers, annual salaries, rent years 
employed at the same job, and years living at the same address. Have the computer print the 
application numbers of people who are eligible for a credit card. to be eligible, one must have a 
salary of over $25,000 per year, or have an annual salary of over $20,000 and pay a rent of less 
than one quarter of a month's salary, or have an annual salary of over $15,000 and be living at 
the same address for more than 5 years or have an annual salary of at least $10,000 and be living 
at the same address for at least 5 years and be employed at the same job for at least 3 years. All 
other applications are rejected.*/
using System;

class Salary
{
    public decimal AnnualSalary { get; set; }
    public int RentYears { get; set; }
    public int EmployedYears { get; set; }
    public int LivingYears { get; set; }

    public Salary(decimal annualSalary, int rentYears, int employedYears, int livingYears)
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

class CreditCardApplication
{
    static void Main(string[] args)
    {
        int[] appNumbers = new int[10];
        Salary[] salaries = new Salary[10];

        // Input data for each application
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Application #" + (i + 1) + ":");
            Console.Write("Annual salary: $");
            decimal annualSalary = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Rent years: ");
            int rentYears = Convert.ToInt32(Console.ReadLine());
            Console.Write("Years employed: ");
            int employedYears = Convert.ToInt32(Console.ReadLine());
            Console.Write("Years living at the same address: ");
            int livingYears = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            appNumbers[i] = i + 1;
            salaries[i] = new Salary(annualSalary, rentYears, employedYears, livingYears);
        }

        // Check eligibility for each application and print eligible ones
        Console.WriteLine("Eligible applications:");
        for (int i = 0; i < 10; i++)
        {
            if (salaries[i].IsEligibleForCreditCard())
            {
                Console.WriteLine("Application #" + appNumbers[i]);
            }
        }
    }
}
