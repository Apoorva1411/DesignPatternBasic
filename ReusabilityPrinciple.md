# Reusability Principle

Reusable is re-using the code component without re-defining the implementation.
Reusability can be broadly classifed as 
<ul>
  <li>Complete code Re-Use</li>
  <li> Object Re-Use</li>
</ul>
<br />

After defining classes with responsibilites , next task would be creating a relationship between these classes. WIth this reusability principle we can defile two relationship btw classes i.e <i>"is a"</i> relationship and <i>"has a"</i> relationship.

<h2>Complete code Re-Use (Inheritance)</h2>
<br />
  In general , Application will be developed using group of classes .
These group of classes contains commonality and variations.The commonality present might lead to Code dupplication(if not separated).
Hence this commanality can be separated into common class and all other classes can inherit from this base class. This concept is called as <b><i>Inheritance</b></i>.
WIth inheritance we will define "is a " relationship between two classes.
<br />
Inheritence to be applied only if :
<br />
<br />
<ul>
  <li><i>Group of classes form family</i></li>
  <li><i>other classes uses complete code present in Base class</i></li>
</ul>

<br />
<h2>Object Re_Use</h2>
    Instead of reusing the complete code we can reuse the part of code exposed through object creation. Hence we will define "has a" relationship between classes.
    Object re-use can be brodly classified as 
    <br />
    <br />
    <ul>
      <li><i>Association</i></li>
      <li><i>Composition</i></li>
      <li><i>Aggreration</i></li>
    </ul>
 
 <h3>Association</h3>
      This tells that one object <i>"belongs"</i> to another object. 
      Ex: Lab report object belongs to Patient object (we use unique patient id as reference here.
      
 <h3>Composition</h3>
      This tells that object A <i>"contains"</i> object B. LifeSpan of object B is dependant on object A.
      Ex: Window contains control which gets deleted when we close the window.

      
 <h3>Aggreration</h3>
      This tells that object A <i>"holds"</i> object B. LifeSpan of object B is not dependant on object A.
      Ex: Company holds SoftwareEngineers. where SoftwareEngineers can exist without company.


