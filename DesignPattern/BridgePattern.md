<h1>Bridge Pattern </h1>

​				This pattern is applicable if we have many abstraction and many implementation then we can use this pattern to avoid multiple inheritance . With this pattern we separate Abstraction from implementation . This pattern involves an interface which acts as a bridge which makes the functionality of concrete classes independent from interface implementer classes. Both types of classes can be altered structurally without affecting each other.



For Example We can take Usage of many remote functionality for different appliances. Here Remote functionality can be considered as abstraction which tells what the functionality does but is not concerned with how. Where as we have set of classes for implementation which tells how is the functionality implemented.

Please find the below UML for the same

<img src="Images\BridgePattern.PNG" style="zoom:80%;" />
