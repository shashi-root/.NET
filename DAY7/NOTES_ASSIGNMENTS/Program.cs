using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


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

/*  //Attributes , Indexers
namespace NOTES_ASSIGNMENTS
{
   class Program
   {
       static void Main(string[] args)
       {
           class1 o = new class1();                    //Indexer
           o[0] = 10;
           o[1] = 20;
           o[2] = 20;
           Console.WriteLine(o[0]+" "+o[1]);

           Console.ReadLine();
       }
   }
   public class class1
   {
       private int[] arr = new int[5];
       public int this[int sub]
       {
           get { return arr[sub]; }
           set { arr[sub] = value; }
       }
   }
}*/
