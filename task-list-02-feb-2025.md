# C# Software Developer: PayrollSystem

## Task List

Task 1 [+]: Modify the payroll system of Figs. 12.4–12.9 to include private instance variable birthDate in class Employee. 

Task 2 [+]: Use the class Date of Fig. 10.7 to represent an employee’s birthday. 

Assume that payroll is processed once per month.
 
Task 3 [+]: Create an array of Employee variables to store references to the various employee objects. 

Task 4 [+]: In a loop, calculate the payroll for each Employee (polymorphically) 

Task 5 [+]: and add a €100.00 bonus to the person’s payroll amount (total earnings) 

Task 6 [+]: if the current month is the month in which the Employee’s birthday occurs.

Task 7 [+]: Add properties to the class Employee to represent an employee’s home address, 

Task 8 [+]: ...email,

Task 9 [+]: ...and phone number. 

Task 10 [+]: Modify the employee concrete classes so that new employee objects are assigned values for the new properties 

Task 11 [+]: and modify all program parts to process these new details.

Task 12 [+]: Modify the ToString() method in class Employee to include the new properties.

### Discussion

29 JAN

- Conversion of text date input field to Date class
- Solution offered by N.K.: parse to array via private int[] extractDate(string dateString)

02 FEB

- Calculation of monthly salary for hourly employees who are paid weekly. 
- Salaried employees internal earnings calculation is on a weekly basis
- (weekly x 52) / 12 is more accurante than weekly x 4, an 8.3% difference.