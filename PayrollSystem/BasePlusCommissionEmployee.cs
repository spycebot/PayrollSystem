﻿// Fig. 12.8: BasePlusCommissionEmployee.cs
// BasePlusCommissionEmployee class that extends CommissionEmployee.
using System;

public class BasePlusCommissionEmployee : CommissionEmployee
{
   private decimal baseSalary; // base salary per week

   // six-parameter constructor
   public BasePlusCommissionEmployee(string firstName, string lastName, string homeAddress, string phoneNumber,
      string birthDate, string socialSecurityNumber, string email, 
      decimal grossSales, decimal commissionRate, decimal baseSalary)
      : base(firstName, lastName, homeAddress, phoneNumber, birthDate, socialSecurityNumber, email,
           grossSales, commissionRate)
   {
      BaseSalary = baseSalary; // validates base salary
   }

   // property that gets and sets 
   // BasePlusCommissionEmployee's base salary
   public decimal BaseSalary
   {
      get
      {
         return baseSalary;
      }
      set
      {
         if (value < 0) // validation
         {
            throw new ArgumentOutOfRangeException(nameof(value),
               value, $"{nameof(BaseSalary)} must be >= 0");
         }

         baseSalary = value;
      }
   }

   // calculate earnings
   public override decimal Earnings() => BaseSalary + base.Earnings();

   // return string representation of BasePlusCommissionEmployee
   public override string ToString() =>
      $"base-salaried {base.ToString()}\nbase salary: {BaseSalary:C}";
}


  
                 
                             
                                                                         
       
              
            
          
    
     
          
          
                         
   
