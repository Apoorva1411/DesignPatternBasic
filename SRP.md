# Single Resposibility Principle
>
  This responsibity is related to <strong><em>"Encapsulation"</em></strong> concepts in OOPS.
  >
  As per this principle, One class/ function should have one reason for existence i.e one responsibility.
  >
  Data and Methods related to that class would be bound together.
  >
  Therefore  <strong><em>Maintenabilty</em></strong> of class would be easier with minimal change when we have to alter the existing code.
  
>
  During Design ,
  <ul>
    <li>Designer must identify the roles required</li>
    <li>Decide on responsibity of each role</li>
    <li>Naming convention of Class should clearly define the role</li>
    <li>Class should have single responsibility </li>
  </ul>
  
  Example : 
  
  Lets take example of designing Task management project which creates task and schedule the same/
  We will have two main role in this case i.e Task Scheduler and Task Manager. Please find below the definition of classes/
  
    // Responsibility of class is to schedule the task present in queue
    public class TaskScheduler
    {
        private IQueue queue;
        public TaskScheduler()
        {
            //Constructor
        }
        public void Schedule()
        {
            //scheduler
        }
    }
    
    
    // Responsibility of class is to create and queue the task into queue.
    public class TaskManager
    {  
        public TaskManager()
        {
        }

        public void TaskCreation()
        {
         //creation of task   
        }
    }
  
