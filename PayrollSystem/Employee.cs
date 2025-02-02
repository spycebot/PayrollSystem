// Fig. 12.4: Employee.cs
// Employee abstract base class.
public abstract class Employee
{
   public string FirstName { get; }
   public string LastName { get; }
   public string SocialSecurityNumber { get; }

    public Date BirthDate {  get; }

   // three-parameter constructor
   public Employee(string firstName, string lastName,
      string socialSecurityNumber, Date birthDate)
   {
      FirstName = firstName;
      LastName = lastName;
      SocialSecurityNumber = socialSecurityNumber;
      BirthDate = birthDate;
   }

   // return string representation of Employee object, using properties
   public override string ToString() => $"{FirstName} {LastName}\n" +
      $"social security number: {SocialSecurityNumber}\n" +
      $"birth date: {BirthDate}\n";

    // abstract method overridden by derived classes
    public abstract decimal Earnings(); // no implementation here
}


  
                 
                             
                                                                         
       
              
            
          
    
     
          
          
                         
   
