# Single Responsibility Principle
​	

​			This Principle can be corelated to <strong><em>"Encapsulation"</em></strong> concepts in OOPS.As per this principle, One class/ function should have one reason for existence i.e. one responsibility. Doing this  <strong><em>Maintenabilty</em></strong> of class will be easier with minimal change when we have to alter the existing code. Following steps can be followed during design so that we don't violate Single Responsibility Principle.

><ul>
  <li>Designer must identify the roles required</li>
  <li>Decide on responsibity of each role</li>
    <li>Naming convention of Class should clearly define the role</li>
    <li>Class should have single responsibility </li>
    </ul>

  Example : 

​	 		Lets take general example of Movie Booking System . In order to design this application , we need to  define roles . We need repository to store movie data , theatre data  and we need search engine for them and we need booking service to book tickets. Hence we will have to create classes with required functionality.

Please find below UML diagrams of classes with their responsibility for movie booking: 

![](Images\SRP_ClassesWithResponsibility.png)





As depicted above , Each class has only one responsibility .Any change in search logic would need to change class handling Search . Hence this will help us to ***maintain code***.

