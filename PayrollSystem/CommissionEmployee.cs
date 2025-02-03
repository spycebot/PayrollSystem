﻿// Fig. 12.7: CommissionEmployee.cs
// CommissionEmployee class that extends Employee.
using System;
using System.Net.NetworkInformation;

public class CommissionEmployee : Employee
{
   private decimal grossSales; // gross weekly sales
   private decimal commissionRate; // commission percentage

   // five-parameter constructor
   public CommissionEmployee(string firstName, string lastName,
      string homeAddress, string phoneNumber,
      string birthDate, string socialSecurityNumber, string email, decimal grossSales, decimal commissionRate)
      : base(firstName, lastName, homeAddress, phoneNumber, birthDate, socialSecurityNumber, email)
   {
      GrossSales = grossSales; // validates gross sales
      CommissionRate = commissionRate; // validates commission rate
   }

   // property that gets and sets commission employee's gross sales
   public decimal GrossSales
   {
      get
      {
         return grossSales;
      }
      set
      {
         if (value < 0) // validation
         {
            throw new ArgumentOutOfRangeException(nameof(value),
               value, $"{nameof(GrossSales)} must be >= 0");
         }

         grossSales = value;
      }
   }

   // property that gets and sets commission employee's commission rate
   public decimal CommissionRate
   {
      get
      {
         return commissionRate;
      }
      set
      {
         if (value <= 0 || value >= 1) // validation
         {
            throw new ArgumentOutOfRangeException(nameof(value),
               value, $"{nameof(CommissionRate)} must be > 0 and < 1");
         }

         commissionRate = value;
      }
   }

   // calculate earnings; override abstract method Earnings in Employee
   public override decimal Earnings() => CommissionRate * GrossSales;

   // return string representation of CommissionEmployee object
   public override string ToString() =>
      $"commission employee: {base.ToString()}\n" +
      $"gross sales: {GrossSales:C}\n" +
      $"commission rate: {CommissionRate:F2}\n" +
      $"commission value: {(CommissionRate * GrossSales):C}";
}

















