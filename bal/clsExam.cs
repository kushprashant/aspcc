﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bal
{
    public class clsExam
    {
        public int? Id { get; set; }
        public int CoruserId { get; set; }
        public string Name { get; set; }
        public int noofQestion { get; set; }
        public bool Isactive { get; set; }
    }
    public class clsExamQuestionOp
    {
        public int? Id { get; set; }
        public int ExamId { get; set; }
        public string Question { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public short CorrectAns { get; set; }
        public bool IsDelete { get; set; }

    }

}
