

<h1>Composite Pattern </h1>	

​						This pattern adheres to "***Open Closed  Principle***. If our design has hierarchy , then we can use this pattern . As per this pattern group of algorithm or strategy can be made as composite strategy. This class can be substituted with Leaf class(Single algorithm). This helps classes open for expansion but closed for modification as explained in OCP. 

For Example we can take Patient search service UML shown below : 



<img src="Images\OCD.png" style="zoom:80%;" />



​	Here ISearchStartegy is used to search patient either by Name or MRN or contact number or combination of any.  We can define leaf class which searches the repository with one search parameter. To search within combination , we have created a Composite node called SearchStartegy with loops through the leaf strategy and returns the result . This will remove the need of creation of classes for every combination.
