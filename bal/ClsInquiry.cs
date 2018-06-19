using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bal
{
   public class ClsInquiry
    {
        public Nullable<int> Id { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string CourseID { get; set; }
        public string EmailId { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public int AreaId { get; set; }
        public Nullable<int> City { get; set; }
        public string PreferTimeTO { get; set; }
        public string PreferTimeFrom { get; set; }
        public Nullable<bool> Final { get; set; }
        public string Notes { get; set; }
        public Nullable<System.DateTime> EntDt { get; set; }
        public Nullable<int> EntBy { get; set; }
        public Nullable<System.DateTime> ModDt { get; set; }
        public Nullable<int> ModBy { get; set; }
    }
}
