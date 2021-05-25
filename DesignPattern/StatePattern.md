<h1>State Pattern </h1>

​					As pattern is applicable for finite state machine i.e application which toggles between states based on some condition.  This can be a cleaner way for an object to change its behavior at runtime without resorting to conditional statements and thus improve maintainability.



For Example , we can take Bank Account transaction based on our Balance , we can see our account in different states like Active , Suspended or ODState. The transition happens with some condition i.e available balance is less than min balance etc. This pattern can be achieved by using Single Responsibility and  Dependency Inversion principle. We will have to identify the responsibility of each state and define class. Later substitute it with current state of account. Please find UML for same.



![](Images\StatePattern.PNG)

