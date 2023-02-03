using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                String employeeName;
                double basicSalary;
                int numberOfDaysWork;
                double HARPercentage;
                double conveyanceAllowance;
                double medicalAllowance;
                Console.WriteLine("Enter Employee Name");
                employeeName = Console.ReadLine();
                Console.WriteLine("Enter Basic Salary");
                basicSalary = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter  Number of Days worked in a Month");
                numberOfDaysWork = Convert.ToInt32(Console.ReadLine());
                if (numberOfDaysWork>31)
                {
                    throw new Exception("Number of Days worked in a Month must be less than 31");
                }
                Console.WriteLine("Enter HAR Percentage");
                HARPercentage = Convert.ToDouble(Console.ReadLine());
                if (HARPercentage>=100)
                {
                    throw new Exception("HAR Percentage Must be less than 100");
                }

                Console.WriteLine("Enter Conveyance Allowance");
                conveyanceAllowance = Convert.ToDouble(Console.ReadLine());
                if (conveyanceAllowance > basicSalary)
                {
                    throw new Exception("Conveyance Allowance must be less than Basic Salary");
                }

                Console.WriteLine("Enter Medical Allowance");
                medicalAllowance = Convert.ToDouble(Console.ReadLine());
                if (medicalAllowance > basicSalary)
                {
                    throw new Exception("Medical Allowance must be less than Basic Salary");
                }

                double taxExemption = conveyanceAllowance + medicalAllowance + basicSalary * 20 / 100;
                double taxableIncome = basicSalary + numberOfDaysWork * 100 - taxExemption;
                double tax = 0.0;
                if (0 < taxableIncome * 12 && taxableIncome * 12 <= 250000)
                {
                    tax = 0;
                }
                else if (250000 < taxableIncome * 12 && taxableIncome * 12 <= 500000)
                {
                    tax = taxableIncome * 5 / 100;
                }
                else if (500000 < taxableIncome * 12 && taxableIncome * 12 <= 1000000)
                {
                    tax = taxableIncome * 20 / 100;
                }
                else if (taxableIncome * 12 > 1000000)
                {
                    tax = taxableIncome * 20 / 100;
                }



                Console.WriteLine("Employee Name: " + employeeName);
                Console.WriteLine("Salary: " + (basicSalary + numberOfDaysWork * 100));
                Console.WriteLine("Taxable Income: " + taxableIncome);
                Console.WriteLine("Tax Amount: " + tax);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("");
        }
    }
}
