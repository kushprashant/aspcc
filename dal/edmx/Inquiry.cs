//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dal.edmx
{
    using System;
    using System.Collections.Generic;
    
    public partial class Inquiry
    {
        public int Id { get; set; }
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
        public Nullable<bool> IsDelete { get; set; }
    }
}
