// Fig. 12.4: Employee.cs
// Employee abstract base class.
using System;
using System.Runtime.Remoting.Messaging;

public abstract class Employee
{
   public string FirstName { get; }
   public string LastName { get; }
   public string SocialSecurityNumber { get; }

    // Task 1 [+]: ... to include private instance variable birthDate in class Employee. 
    // Task 2 [+]: Use the class Date of Fig. 10.7 to represent an employee’s birthday. 
    private Date BirthDate {  get; }

    // Task 7 [+]: Add properties to the class Employee to represent an employee’s home address, 
    public string HomeAddress { get; }
    // Task 8 [+]: ...email,
    public string Email { get; }
    // Task 9 [+]: ...and phone number.
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

        Console.WriteLine($"dateArray: {convertMonth}, {convertDay}, {convertYear}.");
        Date outputDate = new Date(convertMonth, convertDay, convertYear);
        return outputDate;
    }

    public Date GetDate()
    {
        return BirthDate;
    }

    // return string representation of Employee object, using properties
    // Task 12 [+]: Modify the ToString() method in class Employee to include the new properties.
    public override string ToString() => $"{FirstName} {LastName}\n" +
      $"social security number: {SocialSecurityNumber}\n" +
      $"birth date (M/D/Y): {BirthDate}\n" +
      $"home address: {HomeAddress}\n" +
      $"email: {Email}\n" +
      $"phone number: {PhoneNumber}\n";

    // abstract method overridden by derived classes
    public abstract decimal Earnings(); // no implementation here
}


  
                 
                             
                                                                         
       
              
            
          
    
     
          
          
                         
   
