# C# Software Developer: PayrollSystem

## Problem

(Payroll System Modification) Modify the payroll system of Figs. 12.4–12.9 to
include private instance variable birthDate in class Employee. Use the
class Date of Fig. 10.7 to represent an employee’s birthday. Assume that payroll is
processed once per month. Create an array of Employee variables to store references to
the various employee objects. In a loop, calculate the payroll for
each Employee (polymorphically) and add a €100.00 bonus to the person’s payroll
amount (total earnings) if the current month is the month in which the Employee’s
birthday occurs.
Add properties to the class Employee to represent an employee’s home address, email,
and phone number. Modify the employee concrete classes so that new employee objects
are assigned values for the new properties and modify all program parts to process
these new details.
Modify the ToString() method in class Employee to include the new properties.

### Data

[UML]

### Analysis

### Discussion

Derived class objects may be assigned to base class variables, and base class objects cannot be assigned to derived class variables.