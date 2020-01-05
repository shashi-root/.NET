using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * -----------------------------------Assignment no :: 1---------------------------------------------------
 * 
 * --> (1)(a) create a class called employess with the following properties ( int empno,string name,decimal basic,short deptno)  
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
 * */
namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            employee o = new employee("shashi",100000,1);
            employee o1 = new employee();
            employee o2 = new employee("shivaji", Deptno: 2);
            employee o3 = new employee("shivani", 50000, 3);
            employee o4 = new employee("sanjili", Basic: 500000,Deptno:3);
            employee o5 = new employee("amey");

            // employee o5 = new employee(2,"tushar",150000,2);                    //calling the one without auto genertaion
            //Console.WriteLine(o.Name+" "+o.Empno+" "+o.Basic+" "+o.Deptno);
            Console.WriteLine(o+"\n"+o1+"\n"+o2+"\n"+o4+"\n"+o5);
            //Console.WriteLine(o + "\n" + o1 + "\n" + o2 + "\n" + o4 + "\n" + o5);
            Console.WriteLine("\n New salary for "+" "+o5.Name +" is:: " + o5.CalNextBasic());
            Console.ReadLine();
        }
    }
    class employee
    {
        private int empno;
        private string name;
        private decimal basic;
        private short deptno;

      
       public int Empno                 //read only auto_increament
        {
            get
            {
                return empno;
            }
        }
        public string Name
        {
            set
            {
               if(string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("invalid name");
                    Console.ReadLine();
                    System.Environment.Exit(10);
                }
                else
                {
                    name = value;
                }
            }
            get
            {
                return name;
            }
        }

        public decimal Basic
        {
            set
            {
                if (value < 10000)
                {
                    Console.WriteLine("Invalid basic salary for "+Name);
                    Console.ReadLine();
                    System.Environment.Exit(10);
                }
                else
                {
                    basic = value;
                }
            }
            get
            {
                return basic;

            }
        }

        public short Deptno
        {
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Invalid deptno for "+Name);
                    Console.ReadLine();
                    System.Environment.Exit(10);
                }
                else
                {
                    deptno = value;

                }
            }
            get
            {
                return deptno;
            }
        }

        public employee(string Name="default_name",decimal Basic=10000,short Deptno=1)
        {
            empno = employee2.Empno_inc;
            this.Name = Name;
            this.Basic = Basic;
            this.Deptno = Deptno;
            employee2.empno_inc++;
           
        }
       /* public employee(int Empno,string Name = "default_name", decimal Basic = 10000, short Deptno = 1)
        {
            this.Empno = Empno;
            this.Name = Name;
            this.Basic = Basic;
            this.Deptno = Deptno;

        }*/

        override
        public string ToString()
        {
            return Empno + " " + Name + " " + Basic + " " + Deptno;
        }

        public decimal CalNextBasic()
        {
            return Basic = Basic + 10200 - 3200;
        }
    }

    public class employee2
    {
     public static int empno_inc = 1;

    public static int Empno_inc         //read only static property
        {
            get
            {
                return empno_inc;

            }
        }
    }
}
