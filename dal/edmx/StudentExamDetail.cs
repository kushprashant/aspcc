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
    
    public partial class StudentExamDetail
    {
        public int Id { get; set; }
        public int StudentExamId { get; set; }
        public int QuestionId { get; set; }
        public int Answer { get; set; }
        public System.DateTime EntDt { get; set; }
        public System.DateTime ModDt { get; set; }
    }
}
