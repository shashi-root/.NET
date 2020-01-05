using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_of_the_day
{
    public class employee2
    {
        public static int empno_inc = 0;

        public static int Empno_inc         //read only static property
        {
            get
            {
                return empno_inc;

            }
        }
    }
}
