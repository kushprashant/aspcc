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
    
    public partial class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public decimal Fee { get; set; }
        public Nullable<int> Duration { get; set; }
        public bool Active { get; set; }
        public Nullable<System.DateTime> EntDate { get; set; }
        public Nullable<int> EntBy { get; set; }
        public Nullable<System.DateTime> ModDate { get; set; }
        public int ModBy { get; set; }
        public Nullable<bool> IsDelete { get; set; }
    }
}