

<h1>Command Pattern</h1>					

​			Command pattern is used to encapsulate the information related to request into object . So these objects can be stored and trigger when required. Using this pattern we can log the history of request and  repeat the same request object if necessary. Using command objects makes it easier to construct general components that need to delegate, sequence or execute method calls at a time of their choosing without the need to know the class of the method or the method parameters. Using an invoker object allows bookkeeping about command executions to be conveniently performed, as well as implementing different modes for commands, which are managed by the invoker object, without the need for the client to be aware of the existence of bookkeeping or modes.



For example we can take ICommand interface used in MVVM(Model - View - ViewModel). In MVVM pattern the command cant directly executed on View-Model. Hence the ICommand interface is used to trigger command implementation present in View Model.



Please find UML for same: 

<img src = "Images\CommandPattern.PNG">
