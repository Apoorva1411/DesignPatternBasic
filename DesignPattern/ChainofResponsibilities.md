

<h1>Chain Of Responsibility  </h1>					

​			This pattern can be used when we have chain group of  task to create workflow. The ordering of task within workflow can be created dynamically. Ordering changes for each workflow then this pattern would be of great use 



Example : Take chain of task for Firmware update shown below : 

​	<img src="Images\COR.png" style="zoom:80%;" />





​	Here we have task like Authentication , CacheCheck , BackUp , Configuration and so on . The ordering can be dynamic . In such scenarios, we will create an abstract class of activities and implement same in other firmware activities . Each Activity would set successor through SetSuccessor function . This can be used to set successor at run time rather than static linking. 



​	This pattern looks similar to ***decorator pattern*** but difference is that we can break the chain in this pattern based on workflow where as we will have to execute all classes in decorator pattern to achieve the goal.
