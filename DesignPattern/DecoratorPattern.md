<h1>Decorator Pattern </h1>

​					As name states this pattern helps in adding extra feature to object during runtime rather than static linking. This pattern helps to decorate the set of object at runtime on need basic.

For example We can take Streamer class used widely in frameworks. Please find UML for same

<img src="Images\DecoratorPattern.PNG" style="zoom:80%;" />



​	We can see that we have generalized streamer class which Read(), Write() data byte by byte. We can derived classes Like Network Stream , Memory Stream and File Stream . As per requirement if some of Network stream needs to read data in chunks rathe than byte by byte then we can create a decorator class from base class Streamer and use this decorator when we create Network Stream object . This way we can get the decorator at runtime dynamically without static linking.
