using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTES_ASSIGNMENTS_TODOS
{
    class Employee : IComparable<Employee> 
    {
        private string name;
        public string Name { get { return name; } set{ name = value;} }
        private decimal basic;
        public decimal Basic { set{ basic = value; } get { return basic; } }
        private int deptno;
        public int Deptno { get { return deptno; } set { deptno = value; } }
        public Employee(string Name,decimal Basic,int Deptno)
        {
            this.Name = Name;
            this.Basic = Basic;
            this.Deptno = Deptno;
        }

        public int CompareTo(Employee other)
        {
            if (this.Basic > other.Basic)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public override string ToString()
        {
            return Name + " " + Basic + " " + Deptno;
        }
      
    }
}
