using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOS
{
   public class employee : IComparable<employee>
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
                if (string.IsNullOrEmpty(value))
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
                    Console.WriteLine("Invalid basic salary for " + Name);
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
                if (value < 0)
                {
                    Console.WriteLine("Invalid deptno for " + Name);
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

        public employee(string Name = "default_name", decimal Basic = 100000, short Deptno = 1)
        {
            empno = employee2.Empno_inc;
            this.Name = Name;
            this.Basic = Basic;
            this.Deptno = Deptno;
            employee2.empno_inc++;

        }
      

        override
        public string ToString()
        {
            return Empno + " " + Name + " " + Basic + " " + Deptno;
        }

        public decimal CalNextBasic()
        {
            return Basic = Basic + 10200 - 3200;
        }

        public int CompareTo(employee other)
        {
            if (this.Basic > other.Basic)
            {
                return 1;
            }
            else
                return 0;
        }
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

