

<h1>Visitor Pattern</h1>				

​				This pattern is useful when we have to resolve ***double dispatch*** problem . If Object has a structure which is group of classes. We will have to execute methods present in every class then we can choose this pattern.

​		For Example we can consider Picture which has structure of group of shapes. These shapes may be Square , Rectangle or Circle. We have set of printer like Inkjet , Dot Printer and so on. If we will have to print rectangle in all three printer which creates double dispatch problem , we will have to apply this pattern .



​	We can propose solution to above problem by looping through shapes and down casting it to particular shape and print but this would violate LSP rule . Hence we separate the functionality required to execute on every member into separate class and call it ***Visitor Class*** . The derived class would accept the visitor class object and perform the activity using the current pointer.  Have illustrated same in below diagram: 



![](Images\VisitorPattern.png)



