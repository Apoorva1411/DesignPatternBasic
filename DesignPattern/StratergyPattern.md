

<h1>Strategy Pattern </h1>	

​						This pattern adheres to "***Dependency Inversion Principle***". If service provider class or any   other class has more than one algorithm , using this pattern the choice of algorithm is done at runtime. The algorithm can be  substituted with other algorithm without affected the party using the service.



​		As example we can take any UI Application which has heterogenous data type like Integer , TextBox , Password, Grid, CheckBox , RadioButton and likewise. Validation algorithm would be different for different data type. We can have one interface to validate parameter which takes UIControl as input and returns boolean on validation result. All other validation to implement this interface. Later in Runtime based on Data Type we can choose the algorithm and substitute the algorithm. This pattern is called as Strategy  Pattern where each validation method is considered as a strategy,



Please Find UML for above scenario applying the pattern : 

<img src="Images\StratergyPattern.PNG" style="zoom:80%;" />
