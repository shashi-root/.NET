using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exam.Models
{
    public class Exam
    {
        
       public string UserName { set; get; }
        [DataType(DataType.Password,ErrorMessage ="error")]
        public string Password { set; get; }

    }
}