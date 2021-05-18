# Single Resposibility Principle
>
  This responsibity is related to <strong><em>"Encapsulation"</em></strong> concepts in OOPS.
  >
  As per this principle, One class/ function should have one reason for existence i.e one responsibility.
  >
  Data and Methods related to that class would be bound together.
  >
  Therefore  <strong><em>Maintenabilty</em></strong> of class would be easier with minimal change when we have to alter the existing code.
  
>
  During Design ,
  <ul>
    <li>Designer must identify the roles required</li>
    <li>Decide on responsibity of each role</li>
    <li>Naming convention of Class should clearly define the role</li>
    <li>Class should have single responsibility </li>
  </ul>
  
  Example : 
  
    // Responsibility of class is to maintain details and fetch details of employees
    class Employee
    {
      //class member describing attributes of class Employee
      string name;
      string id;
      string designation;
    
      //Method to operate on Employee data.
      GetEmployeeDetails();
    }
  
