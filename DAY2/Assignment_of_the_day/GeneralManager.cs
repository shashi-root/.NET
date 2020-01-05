using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_of_the_day
{
   
    public class GeneralManager:Manager,IdbFunction
    {
        private string perks;
        public string Perks
        {
            set
            {
                perks = value;
            }
            get { return perks; }
        }
        public GeneralManager(string Name,decimal Basic,short Deptno, int ProjectId,string Perks="default_perks"):base(Name,Basic,Deptno,ProjectId)
        {
            this.Perks = Perks;
            
        }

        override
        public string ToString()
        {
            return "------------GENERAL_MANAGER------------\n-->Emp_no:: "+ Empno + "\n--> Name:: " + Name + "\n--> Basic:: " + Basic + "\n--> Dept_no:: " + Deptno + "\n--> Perks:: " + Perks+"\n\n\n";
        }

        public override void insert()
        {
            Console.WriteLine("Insert GeneralManager Called");
        }

        public override void delete()
        {
            Console.WriteLine("Delete GeneralManager Called");
        }

        public override void update()
        {
            Console.WriteLine("update GeneralManager Called");
        }

    }
}
