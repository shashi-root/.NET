using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_of_the_day
{
    public class clerk : employee,IdbFunction
    {
        public clerk(string Name,decimal Basic,short Deptno,int Overtime=0):base(Name,Basic,Deptno)
        {
            this.Overtime = Overtime;
            this.Basic = Basic;

        }

        private int overtime;
        public int Overtime
        {
            set
            {
                if (value > 0) { overtime = value; }
                else
                {
                    Console.WriteLine("Invalid Overtime Hours"); System.Environment.Exit(10);
                };
            }
            get
            {
                return overtime;
            }
        }
        public override decimal Basic
        {
            set { basic = value; }
            get { return basic; }
        }

        public override decimal calNextSalary()
        {
            Basic = Basic + 50000 - 200;
            return Basic;
        }

        override
         public string ToString()
        {
            return "----------Clerk---------\n-->Emp_ID:: "+ Empno + "\n--> Name:: " + Name + "\n--> Basic:: " + Basic + "\n--> Dept_no:: " + Deptno + "\n--> Overtime: " + Overtime+"\n\n\n";
        }

        public override void insert()
        {
            Console.WriteLine("Insert clerk Called");
        }

        public override void delete()
        {
            Console.WriteLine("delete clerk Called");
        }

        public override void update()
        {
            Console.WriteLine("update clerk Called");
        }
    }
}
