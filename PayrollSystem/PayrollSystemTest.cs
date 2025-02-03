// Fig. 12.9: PayrollSystemTest.cs
// Employee hierarchy test app.
using System;
using System.Collections.Generic;

class PayrollSystemTest
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        //  var emp1 = new Employee("Hemomgwau", "FRance", "132163546");
        // create derived-class objects
        /*
        Date salariedEmployeeDate = new Date(01, 07, 1942);
        var salariedEmployee = new SalariedEmployee("John", "Smith",
            "111-11-1111", salariedEmployeeDate, 800.00M);
        Date hourlyEmployeeDate = new Date(07, 01, 1972);
        var hourlyEmployee = new HourlyEmployee("Karen", "Price",
         "222-22-2222", hourlyEmployeeDate, 16.75M, 40.0M);
        Date commissionEmployeeDate = new Date(08, 31, 1927);
        var commissionEmployee = new CommissionEmployee("Sue", "Jones",
         "333-33-3333", commissionEmployeeDate, 10000.00M, .06M);
        Date basePlusCommissionEmployeeDate = new Date(12, 25, 2001);
        var basePlusCommissionEmployee =
         new BasePlusCommissionEmployee("Bob", "Lewis",
         "444-44-4444", basePlusCommissionEmployeeDate, 5000.00M, .04M, 300.00M);
        */

        var salariedEmployee = new SalariedEmployee("John", "Smith", "1 SeaviewLane", "0871234567", "10 / 1 / 1990", "111 - 11 - 1111",  "photius@shannonware.com", 800.00M);
        var hourlyEmployee = new HourlyEmployee("Karen", "Price", "11 Lakeside Avenue", "0862345678", "14 / 07 / 1985", "222 - 22 - 2222", "photius@shannonware.com", 16.75M, 40.0M);
        var commissionEmployee = new CommissionEmployee("Sue", "Jones", "21 Mountainview Road", "0853456789", "21 / 08 / 1979", "333 - 33 - 3333", "photius@shannonware.com", 10000.00M, .06M);
        var basePlusCommissionEmployee = new BasePlusCommissionEmployee("Bob", "Lewis", "31 Mill Cresent", "0894567890", "31/12/1989", "444-44-4444", "photius@shannonware.com", 5000.00M, .04M, 300.00M);


        /*
        Date testDateTime = new Date(7, 7, 7);

        Console.WriteLine($"Test Date: {testDateTime}");

        Console.WriteLine("Employees processed individually:\n");

        Console.WriteLine($"{salariedEmployee}\nearned: " +
            $"{salariedEmployee.Earnings():C}\n");
        Console.WriteLine(
           $"{hourlyEmployee}\nearned: {hourlyEmployee.Earnings():C}\n");
        Console.WriteLine($"{commissionEmployee}\nearned: " +
            $"{commissionEmployee.Earnings():C}\n");
        Console.WriteLine($"{basePlusCommissionEmployee}\nearned: " +
            $"{basePlusCommissionEmployee.Earnings():C}\n");

        // create List<Employee> and initialize with employee objects
        var employees = new List<Employee>() {salariedEmployee,
         hourlyEmployee, commissionEmployee, basePlusCommissionEmployee};

        Console.WriteLine("Employees processed polymorphically:\n");

        // generically process each element in employees
        foreach (var currentEmployee in employees)
        {
            Console.WriteLine(currentEmployee); // invokes ToString

            // determine whether element is a BasePlusCommissionEmployee
            if (currentEmployee is BasePlusCommissionEmployee)
            {
                // downcast Employee reference to 
                // BasePlusCommissionEmployee reference
                var employee = (BasePlusCommissionEmployee)currentEmployee;

                employee.BaseSalary *= 1.10M;
                Console.WriteLine("new base salary with 10% increase is: " +
                    $"{employee.BaseSalary:C}");
            }

            Console.WriteLine($"earned: {currentEmployee.Earnings():C}\n");
        }

        // get type name of each object in employees 
        for (int j = 0; j < employees.Count; j++)
        {
            Console.WriteLine(
               $"Employee {j} is a {employees[j].GetType()}");
        }
        */

        Console.WriteLine("==========\nAssignment 3 Polymorphic Payroll System Modification\n==========");

        Console.WriteLine("Monthy Payroll Calculation");

        Console.WriteLine($"Today's date is (D/M/Y) {DateTime.Now}");

        int monthSelection = 0;
        while (monthSelection == 0)
        {
            try
            {
                Console.Write("Enter the month for which to run payroll: ");
                String userInput = Console.ReadLine();
                int userIntInput = int.Parse(userInput);
                if (int.Parse(userInput) > 0 && int.Parse(userInput) <= 12)
                {
                    monthSelection = int.Parse(userInput);
                }
                else if (int.Parse(userInput) == -1)
                {
                    monthSelection = -1;
                    Console.WriteLine("Exiting PayrollSystem.");
                    return;
                }
                else
                {
                    monthSelection = 0;
                    Console.WriteLine("Please enter date as a number from 1 to 12 inclusive.");
                }

            }
            catch (FormatException formatException)
            {
                Console.WriteLine($"{formatException.Message}");
            }
        }

        Employee[] employeesArray = new Employee[] {salariedEmployee,
         hourlyEmployee, commissionEmployee, basePlusCommissionEmployee};

        for (int k = 0; k < employeesArray.Length; k++)
        {
            decimal monthlyEarnings = 0;

            //Console.WriteLine($"Employee {k} ({employeesArray[k].GetType()}): {employeesArray[k].Earnings():C}");
            Console.WriteLine($"==========\nEmployee {k} ({employeesArray[k].GetType()}):\n{employeesArray[k]}");
            Date employeeBirthDate = employeesArray[k].BirthDate;
            if (employeesArray[k] is HourlyEmployee || employeesArray[k] is SalariedEmployee)
            {
                // (weekly x 52) / 12 is more accurante than weekly x 4, an 8.3% difference.
                monthlyEarnings = (52 * employeesArray[k].Earnings()) / 12;
            }
            else if (employeesArray[k] is CommissionEmployee || employeesArray[k] is BasePlusCommissionEmployee)
            {
                monthlyEarnings = employeesArray[k].Earnings();
            }
            if (employeeBirthDate.Month == monthSelection)
            {
                Console.WriteLine("Birthday bonus given!");
                Console.WriteLine($"Monthly earnings before bonus: {monthlyEarnings:C}");
                monthlyEarnings += 100;
            }


            Console.WriteLine($"Employee {k} ({employeesArray[k].GetType()}) monthly earnings: {monthlyEarnings:C}");

        }
    }
}


  
                 
                             
                                                                         
       
              
            
          
    
     
          
          
                         
   
