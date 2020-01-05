using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_of_the_day
{
    public class Manager : employee,IdbFunction
    {
        public Manager(string Name, decimal Basic, short Deptno, int ProjectId = 0) : base(Name, Basic, Deptno)
        {
            this.ProjectId = ProjectId;
            this.Basic = Basic;
        }
        private int projectId;
        public int ProjectId
        {
            set { if (value > 0) { projectId = value; } else { Console.WriteLine("Invalid Project ID"); System.Environment.Exit(10); }; }
            get { return projectId; }
        }
        public override decimal Basic
        {
            set { basic = value; }
            get { return basic; }
        }

        public override decimal calNextSalary()
        {

            return Basic+10000-100;
        }
        override
        public string ToString()
        {
            return "--------MANAGER---------\n--> Empno:: "+Empno + "\n--> Name:: "+Name+"\n--> Basic:: "+Basic+"\n--> Dept_no:: "+Deptno+"\n--> Projcet_id:: "+ProjectId+"\n\n\n";
        }

        public override void insert()
        {
            Console.WriteLine("Insert Manager Called");
        }

        public override void delete()
        {
            Console.WriteLine("Delete Manager Called");
        }

        public override void update()
        {
            Console.WriteLine("update Manager Called");
        }
    }
}
