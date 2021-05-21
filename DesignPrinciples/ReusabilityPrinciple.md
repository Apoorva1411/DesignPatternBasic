# Reusability Principle

​			Reusable is re-using the code component without re-defining the implementation.
Reusability can be broadly classified as 

<ul>
  <li>Complete code Re-Use</li>
  <li> Object Re-Use</li>
</ul>
After identification of classes with responsibility. We will have to create relationship between classes so classes can communicate with each other and share resources. In below topics lets try to define few relationship between classes

**Complete code Re-Use (Inheritance)**

​		  In general , Application will be developed using group of classes .These group of classes contains commonality and variations. The commonality present might lead to Code duplication(if not separated).
Hence this commonality should be separated into common class(base class) and all other classes can inherit from this base class. This concept is called as ***Inheritance***.
With inheritance we will define ***"is a"*** relationship between two classes.

Inheritance to be applied only if :

<ul>
  <li><i>Group of classes form family</i></li>
  <li><i>other classes uses complete code present in Base class</i></li>
</ul>
<img src="Images\Inheritence.png" style="zoom: 50%;" />

As shown in Diagram Commonality have been moved to base class i.e Control. Window and Text Box uses this control.

**Object Re-Use **

​		Instead of reusing the complete code we can reuse the part of code exposed through object creation. Hence we will define "**has a**" relationship between classes.
Object re-use can be broadly classified as 

<ul>
  <li><i>Association</i></li>
  <li><i>Composition</i></li>
  <li><i>Aggreration</i></li>
</ul>



**Association**

 This tells that one object <i>"**belongs**"</i> to another object. As shown in Diagram lab Report belongs to Patient and is identified by patient Reference

<img src="Images\Assosiation.png" style="zoom:70%;" />



**Composition**

​	  This tells that object A <i>"**contains**"</i> object B. Life Span of object B is dependent on object A.
  Ex: Window contains control (i.e TextBox)which gets deleted when we close the window.



<img src="Images\Composition.PNG" style="zoom:70%;" />






​      

**Aggregation**

 This tells that object A <i>"**holds**"</i> object B. Lifespan of object B is not dependent on object A.  Ex: Company holds Tester. where Company can exist without Tester.

<img src="Images\Aggregation.PNG" style="zoom:70%;" />

