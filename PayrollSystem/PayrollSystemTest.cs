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

        Date testDateTime = new Date(7, 7, 7);

        Console.WriteLine($"Test Date: {testDateTime}");

        /*

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

        Console.WriteLine("Monthy Payroll Calculation:");

        Employee[] employeesArray = new Employee[] {salariedEmployee,
         hourlyEmployee, commissionEmployee, basePlusCommissionEmployee};

        for (int k = 0; k < employeesArray.Length; k++)
        {
            decimal monthlyEarnings = 0;

            Console.WriteLine($"Employee {k} ({employeesArray[k].GetType()}): {employeesArray[k].Earnings():C}");
            //Console.WriteLine($""
            if (employeesArray[k] is HourlyEmployee || employeesArray[k] is SalariedEmployee)
            {
                monthlyEarnings = 4 * employeesArray[k].Earnings();
            } else if (employeesArray[k] is CommissionEmployee || employeesArray[k] is BasePlusCommissionEmployee)
            {
                monthlyEarnings = employeesArray[k].Earnings();
            }


            Console.WriteLine($"Employee {k} ({employeesArray[k].GetType()}) monthly earnings: {monthlyEarnings:C}");
        }
    }
}


  
                 
                             
                                                                         
       
              
            
          
    
     
          
          
                         
   
