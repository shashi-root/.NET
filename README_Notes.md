

++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
							DAY 1
++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++



/* 
 * -----Assignments--------and NOTES  
 * 
 * TODO--> Create a static property 
 * 
 * Static contructor gets called only once (when class loads in the memory)
 * When first object creates class is loaded or when we call static member
 * Cannot make explicit call to static constructor it's implicitly private (always will be parameter less, cannot be overloaded)
 * 
 * TODO--> Create a static contructor (init static members) non static also
 * TODO--> Create static class
 * 
 * static class can only contain static members ,cannot use it as base class, object creation not allowed,if your class has only static members then you create static class console class is an example
 * 
 *
 *---------------------------------------------------Assigments-------------------------------------------------------
 * 
 *--> (1)(a) create a class called employess with the following properties ( int empno,string name,decimal basic,short deptno)  
 *  1.empno should be greater than 0
 *  2.No blank strings
 *  3.Basic (any range you want)
 *  4.deptno should be greater than 0
 *  write overloaded constructors to initialize the properites
 *  while creating the object use named prameters also
 *  method to calculate next salary which returns a decimal
 * 
 * -->(1)(b) empno should be auto generated
 *  try test cases
 * 
 * 
 * */





+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
								DAY 2
+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


/* -----------------------------------------------------------------------------------------------------------------------------------
 *>_Access secifiers are public,private,protected,internal and protected internal
 * 
 *>_Internal is available in same class and other classes withi same assembly.
 * 
 *>_Protected internal derived class and same assembly.
 * 
 *>_When you hide a method compiler shows warning (remove this warning we can add new in front of void (function defination) code runs exactly the same)
 * 
 *>_Difference between hiding and overriding (any method can be hidden but you can only override virtual method).
 * 
 *>_All methods are virtual by default in java (May be Hiddding not possible not clear)*
 * 
 *>_Becuase of this java is slower than .NET (it's populer because of open source)
 * 
 *>_Sealed method is virtual method that cannnot be overriden (something similer to final)
 * 
 *>_Only overriden method can be sealed (sealed override)
 * 
 *>_Abstract class -- > class should be absract if it has virtual function (you are forced to implement pure virtual functions)
 * 
 *>_Sealed class is something which we cannot use as base class but we can create instance of that class.
 * 
 * TODO-->create sealed class
 * 
 *>_Why modern day programming laguages don't support multiple inhertance --> Because of 2 copies we have trouble selecting which copy to use...Not feasible in real life problems
 * 
 * TODO-->sealed class with sealed method
 * 
 *>_Interfaces are not subsitute for multiple inhertance....If we want standerdization among classes
 * 
 *>_If we use explicit interface we make code as below(We make explicit interface if we have same name of method in different interfaces)
 * 
 *>_All classes and thier varients are refernce type... all struct,enums are value type ....all ref type are stored on heap all value type are stored on stack
 * 
 *>_All classes,interfaces,deligates,arrays,object class and the string classs are reference type 
 * 
 *>_String is the only class which is exception to this rule because it's immutable (It's made to behave like value type)
 * 
 *>_ref varible require inital value....out don't require even if you give it'll ignore that value
 * 
 * ==========================================================================================================================
 *                                               Assigment for today
 * ==========================================================================================================================
 * 
 * 
 * 
 * 
 * 
  
    */






++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
								DAY3
++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

/*NOTES ASSIGNMENTS TODOS
 * -------------------------------------------------------------------------------------------------------------
 * >_Stack memory is faster than heap that is why struct enum is faster than class
 * >_enum is collection of constants
 * >_By default enums are integers
 * >_value type don't have ability to store nulls but if we want to we can use nullable type why we need when we are dealing with databases.
 * >_all arrays inherit from array class in .NET you would get certain properties it's abstract class we can't crete object of it
 * 
 * 
 * -->TODO--accept marks for 5 students display marks of lowest and highest
 * -->TODO--Create an array of 5 employess accept the deatails and diplay the employee with the highest basic salary
 * -->TODO--Accepts marks in 3 subjects for 5 students display the index number of student with highest aggregate marks
 * -->TODO--There are 3 departments in an office there are 5 employess in every department accept the details for all emploees and diplay the dept number with highest basic salary
 * 
 * 
 * >_jagged array is the one with mix number of values means array of arrrys
 * 10 20 30
 * 40 50
 * 60 70 80 90 //this is jagged array
 * int [][] array of int array it's one of jagged array eg 3 cdac centres having different no of students
 * 
 * -->TODO--accept no of cdac centers. for each center accept no of students in each center. accept marks for all the students display the marks.*display the highest mark in each center
 * -->*TODO--accept no of cities then no center in each center there may be multiple cources accepts no students for each cource
 * 
 * >_Generics 
 * >_Collections in .NET (IEnumberable is the base interface of all collection hierarchy)
 * >_ICollection --->LIST DICTIONARY(key,value)
 * 
 * 
 *                                             |Ienumerable
 *                                             |
 *                               ______________|Icollection__________
 *                              |Ilist                               |IDictionary
 *  
 *  
 * >_Collections has methods add,remove,count(these are from Icollection interface)
 * 
 * -->TODO --Accept details for 5 employees in a collection based on a Generic Ilist (List) display details for the employee with the highest salary
 *           Accept an empno to be searched and display details for that employee
 *           Do the same thing with the collection based on generic Idictionary
 * 
 * >_Delegate are like function pointers(here job is calling a function)
 * >_Delegate is a class which inherits from Multicastdeligate class 
 * >_syntax:: public delegate void Mydel()
 * 
 *              ---------------------Create delegate---------------------------
 * >_Step 1: Create a delegate class having same signature as a function to call
 * >_Step 2: Create an object of delegate class,passing only function name as a parameter.
 * >_Step 3: Call the function using the delegate object.
 * 
 * 
 *          -------------------------------Delegate------------------------------
 * TODO--->Method that has parameters 
 *         Method that parametes and return value
 *         Method present in another class
 *         Static method in another class
 *         (clue:Read the steps)
 * 
 * 
 * 
 
     */









/* // NOTES ASSIGNMENTS TODOS
 * --------------------------------------------------------------------------------------------------
 *                                              DAY-4
 * --------------------------------------------------------------------------------------------------
 * >_Exception handling
 * 
 *               ________________________________|Exception________________________
 *              |SystemException                                                   |AapplicationException(defined By Programmer)
 *              
 * >_finally block
 * 
 * TODO-->Throw Excption from a property.
 * 
 * >_Event
 * >_Create a delegate class having same signature as the event handler.
 * >_Event handler always has return type void
 * 
 * >_Threading
 * >_one way to create thread is delgatate
 * 
 * >_Annonymous method can access calling code variables.
 * 
 * 
 * 
 * 
 * 
 * */








/* //NOTES_ASSIGNMENTS_TODOS
 * -------------------------------------------------------------------------------------------------
 *                                             DAY5
 * -------------------------------------------------------------------------------------------------
 * 
 * >_Threads
 * >_Foreground Threads
 * >_Background Thread is thread which does not wait for another.
 * >_IsBackground is a method to do....by default thread is foregrund.
 * >_Non_critical thread can be kept as background thread.(suppose a program which is checking new file is added or not should be background and 
 *      critical should be foreground.
 * >_Thread.Abort()   //abort a thread.
 * >_You can't create a Thread of a funtion that has return type. You are forced to use delegate. (can be achieved with shared varible(global) or with annonymous method.....coolest way is delegates)
 * >_Thread_Pool
 * >_Thread_Synchronization (lock)
 * >_Synchronization using lock
 * >_InterLock
 * 
 * 
 * >_Lambda Expression    //used for shorter functions (represents a function)
 * 
 * 
 * //********* Most of the Questions will be on => delegate thread tasks
 * 
 * //Task ASyncAndawait
 * 
 * >_Linq 
 *      ~ Implicit var - Implicit type is used for adopting type like in case of class .class could be of any type so to adopt we need var
 *      ~ Annonymous type that does not have a type(class,struct,enum,interface,delegate) Classes that dont have the name.
 *      ~ We can add our own method in another class. (you can add method in string class which is inbuilt)
 *      ~ >_Steps to add extension method
 *      ~ >_step 1 : Create a static method in a static class. First parameter of this method will be the class for whom you are writting the method,
 *                   preceded by this keyword.
 *     ~ Partial classes used in Linq to sql 
 *     ~ partial is a class. partial method
 *     ~ Partial method is like placeholder we are leaving a place.
 * 
 * 
 * */



/*  //NOTES
 *  
 *  ---------------------------------------------------------------------------------------------
 *                                                DAY-6
 *  ---------------------------------------------------------------------------------------------
 *  
 *  >_LINQ
 *  >_Differed execution ...
 *  >_Async Await
 *  >_File ops
 *  >_Serialization (serializable) SOAP
 *  >_Reflection in .NET
 *   
 *  
 *  
 *  
 *  
 *  
 *  
 *  */




/* //NOTES
 * ---------------------------------------------------------------------------------------------
 *                                             DAY-7
 * ---------------------------------------------------------------------------------------------
 * 
 * 
 * 
 * >_Reflection
 * TODO--> store marks of students using indexer
 * >_Shared assembly
 * >_All assemblies are private by default
 * >_When we add refernce of assebly we get private copy of added ref assembly.That is why we need shared assembly.
 * >_Golobal assembly cache(common location where all shared assemblies are stored)
 * >_1.Generate key pair command (sn -k mykey.snk)
 * >_2.sign assmebly with key pair (from properties)
 * >_3.Build assembly
 * >_4.Install assembly into GAC(global assembly cahce)
 *     GacUtil /i assem1.dll        /i for install
 * >_WPF(Windows presentation foundation) before this we had winforms.
 * 
 * --------------------------------------------------------------------------
 *                      WPF & Dealing with database
 * --------------------------------------------------------------------------
 * 
 * >_Data reader is connected,readonly,forward only way of accessing records
 * >_Data reader is also called a firehost cursor.
 * >_DataSet (Not into 3 object(Common for all))
 * >_Dataset is a disconnected xml set of records.(updatable but disconnected.).
 * >_ADO.NET is completly different.(not same as Activex data objects).
 * >_DataAdapter((*3)_add prefix(sql,oledb,odbc)).Two methods in dataadapter are fill and upadte.(feteches data and fills to database.)
 * >_Dataview is based on a singel data table it has the same structure as data table.(sorting and filtering is possible with dataview)
 *    ~ changes made in the view reflect in the data table and vica-versa.
 *    ~ one data table can have multiple data views.
 *    ~ every data table comes with a degfault view. 
 * 
 * (localdb)\MsSqlLocalDb
 * 
 * 
 * 
 * 
 * */









//============================================================MVC Web App==================================================

//Hidden and hidden for difference //Values from model will be puten to controlls...If model changes view changes if view changes model changes
//minimization (set debug=false minimization gets enabled)
//bundling(Putting in all files together)
/*
* To enable bundling set debug=false 
* Register bundles is method in bundle-config
* App-start is first thing that happens after install.
* Set nullable ? (if you want null value to be allowed.
* RedirectToRoute - Action - URL

//----------------------------------------------------------------
* State management ------------------------------------------------
* View bag is valid only for current request.		     //ViewBag is Dyanmic Object
*
* ViewData = ViewData["<_key_>"]=id;					//Collection Dictionary Based where key is string and value is object
* Internally view bag stores data in view data.

* TempData is used to pass between requests if redirect. Available across redirects(Not on different requests)

* Session variable (session is interaction between server and client.)(Default expiry is 20 min(can be changed))
* Sliding expiration of 20 min(If there is no responce for 20 mins.and if there is it'll slide for 20 mins)
*
* Session.abandoned() to invalidate session
//------------------------------------------------------------------

* Cookies is small piece of information stored on client browser.
* Store user preferences(Use cookies)
* create object of type cookie HttpCookie obj=new HttpCookie("<_name of cookie_>");
* //obj.value=emp.Name;
*	we can set multiple values also
*	obj.values["Name"]=emp.name;
*	obj.values=emp.Basic;
* obj.Expires = DateTime.Now.AddDaya(30) //30  from current date
* Resopnse.Cookie.Add(obj);
*            -----------
* HttpCookie obj=Request.Cookies["<_name_of_cookie_>"]
  if(obj!=null){
     ViewBag.Cookievalue=obj.value;
  }
* 

-->TODO
----------------------------------------------------------------------------------------
Register 
Username pass confm pass email Dob Contact No Gender Address
Register and reset button

----------------------------------------------------------------------------------------
			______________
Username   [______________]
			______________
Pass       [_____________]

[] remember me

[LOGIN]

------------------------------------------------------------------------------------------

home 
Welcome <_FULL_NAME_>
Link updateprofile
logout button


and 

UpdateProfile

only required fileds
 Username(display Only)
 FullName
 email
 Dob 
 Contact No 
 Gender 
 Address


/*Next day /
----------------------------------------------------------------------------------------------------------------------

--------------------------------WEBServices-------------------------------------------------------------------
* Add service ref WSDL file(All the information methods parameters everthing)
* SOAP envolop(xml)
* Soap doesn't have any long form now


-------------------------WCF(WindowsCommunicationFoundation)---------------------------------------

* Remoting (Extra read)
* WCF Service---------------
* ABC( Address(where),binding(how),contract(What is available) ) in WCF
* [ServiceContrect]
* [OperationContract]
* Mex Endpoint (metadata expose)
* One-Way-Method
* [Dual-Bindding]
* MTS(Microsoft transactional services)
* if we don't have a proxy class (i.e not mex)then we can create chhanel

---------------------------TODOS----------------------------------------------------------
[oneWayMethod]

using WCF service create

--> DataSet(){}
--> Update data(){}

*/-----------ASP.NET MVC....WEB Service....WCF service

----------------------------------------------LastDay-----------------------------------------

* Authentication
* Authoriztion
* RestFul Service 
* WEB API
* WCF Service


