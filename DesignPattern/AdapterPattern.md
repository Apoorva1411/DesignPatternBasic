

<h1>Adapter Pattern</h1>					

​			This pattern is used to resolve ***"Interface mismatch"*** problem. Interface mismatch states that two interface cannot interact with each other because of its signature.  These situation might occur if we use legacy codes. We will have to use adapter to  interact with such interfaces. This pattern introduces Adopter which takes responsibility of communicating between two interfaces which has mismatch.



There are two types of Adapter Pattern 

<ul> <li>Object Adapter Pattern</li> <li>Class Adapter Pattern</li>



<h2> Object Adapter Pattern </h2>

​		In this adapter pattern, the adapter contains an instance of the class it wraps(. In this situation, the adapter makes calls to the instance of the wrapped object. Please find UML for same

<img src="Images\ObjectAdapterPattern.png"/>



<h2>Class Adapter Pattern</h2>

​	This adapter pattern uses multiple polymorphic interfaces implementing or inheriting both the interface that is expected and the interface that is pre-existing.

Please find UML for same : 

<img src="Images\ClassAdapterPattern.png"/>
