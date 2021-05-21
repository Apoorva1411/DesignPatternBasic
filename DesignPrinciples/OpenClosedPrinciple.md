<h1> Open Closed Principle</h1>

​						This principle states that " *Classes must be open for Expansion but closed for Modification*".

Lets take example of Movie Booking again: Please find the classes and responsibility as shown in below diagram: 

![](Images\SRP_ClassesWithResponsibility.png)



Here We can separate the search class which search with certain condition and later we can have interface implemented and given to booking service as shown below 

<img src="Images\OCD.png" style="zoom:70%;" />



In this scenario , we can route the search mechanism based on requirement , if we need to create one more search parameter , we can introduce it. Now if we have requirement we want to combine two search criteria , then we can use this principle . We can create one ***composite search class*** which has all search objects and can search with multiple condition . With this now we are open to expansion without modification. Addition of new search criteria would be as simple as adding new search class implementing interface and added it to composite search class. Please find UML for same: 



<img src="Images\OCD2.PNG" style="zoom:70%;" />







​	
