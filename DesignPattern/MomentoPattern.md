<h1>Momento Pattern</h1>

​		The **memento pattern**  provides the ability to restore an object to its previous state. The memento pattern is implemented with three objects: the *originator*, a *caretaker* and a *memento*. The originator is some object that has an internal state. The caretaker is going to do something to the originator, but wants to be able to undo the change. The caretaker first asks the originator for a memento object. Then it does whatever operation (or sequence of operations) it was going to do. To roll back to the state before the operations, it returns the memento object to the originator. The memento object itself is an [opaque object](https://en.wikipedia.org/wiki/Opaque_data_type) (one which the caretaker cannot, or should not, change). When using this pattern, care should be taken if the originator may change other objects or resources—the memento pattern operates on a single object.

For Example we can consider TextEditor which does undo operation when user wants to move back to previous state. Please find UML for same.



<img src="Images\MomentoPattern.png" style="zoom:100%;" />



