using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bal
{
   public class clsCourse
    {
        public Nullable<int> Id { get; set; }
        public string CourseName { get; set; }
        public decimal Fee { get; set; }
        public Nullable<int> Duration { get; set; }
        public bool Active { get; set; }
        public Nullable<System.DateTime> EntDate { get; set; }
        public Nullable<int> EntBy { get; set; }
        public Nullable<System.DateTime> ModDate { get; set; }
        public int ModBy { get; set; }
    }
}
