// Fig. 12.4: Employee.cs
// Employee abstract base class.
using System;
using System.Runtime.Remoting.Messaging;

public abstract class Employee
{
   public string FirstName { get; }
   public string LastName { get; }
   public string SocialSecurityNumber { get; }

    public Date BirthDate {  get; }

    public string HomeAddress { get; }
    public string Email { get; }
    public string PhoneNumber { get; }

    // three-parameter constructor
    public Employee(string firstName, string lastName,
      string homeAddress, string phoneNumber,
      string birthDate, string socialSecurityNumber, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        SocialSecurityNumber = socialSecurityNumber;
        BirthDate = ConvertToDate(birthDate);
        HomeAddress = homeAddress;
        Email = email;
        PhoneNumber = phoneNumber;
    }

    private Date ConvertToDate(string inputDate)
    {
        string[] dateArray = inputDate.Split('/');
        int convertMonth = int.Parse(dateArray[1]);
        int convertDay = int.Parse(dateArray[0]);
        int convertYear = int.Parse(dateArray[2]);
        // Console.WriteLine($"dateArray: {int.Parse(dateArray[0])}, {int.Parse(dateArray[1])}, {int.Parse(dateArray[2])}.");
        Console.WriteLine($"dateArray: {convertMonth}, {convertDay}, {convertYear}.");
        // Date outputDate = new Date(2, 2, 2);
        Date outputDate = new Date(convertMonth, convertDay, convertYear);
        return outputDate;
    }

    // return string representation of Employee object, using properties
    public override string ToString() => $"{FirstName} {LastName}\n" +
      $"social security number: {SocialSecurityNumber}\n" +
      $"birth date: {BirthDate}\n";

    // abstract method overridden by derived classes
    public abstract decimal Earnings(); // no implementation here
}


  
                 
                             
                                                                         
       
              
            
          
    
     
          
          
                         
   
