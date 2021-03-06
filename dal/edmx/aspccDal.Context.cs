﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class aspccEntities : DbContext
    {
        public aspccEntities()
            : base("name=aspccEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Inquiry> Inquiries { get; set; }
        public virtual DbSet<Admission> Admissions { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<ExamQuestionOp> ExamQuestionOps { get; set; }
        public virtual DbSet<StudentExam> StudentExams { get; set; }
        public virtual DbSet<StudentExamDetail> StudentExamDetails { get; set; }
    
        public virtual ObjectResult<Nullable<int>> CourseInsertUpdate(Nullable<int> id, string courseName, Nullable<decimal> fee, Nullable<int> duration, Nullable<bool> active, Nullable<int> entBy, Nullable<int> modBy)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var courseNameParameter = courseName != null ?
                new ObjectParameter("CourseName", courseName) :
                new ObjectParameter("CourseName", typeof(string));
    
            var feeParameter = fee.HasValue ?
                new ObjectParameter("Fee", fee) :
                new ObjectParameter("Fee", typeof(decimal));
    
            var durationParameter = duration.HasValue ?
                new ObjectParameter("Duration", duration) :
                new ObjectParameter("Duration", typeof(int));
    
            var activeParameter = active.HasValue ?
                new ObjectParameter("Active", active) :
                new ObjectParameter("Active", typeof(bool));
    
            var entByParameter = entBy.HasValue ?
                new ObjectParameter("EntBy", entBy) :
                new ObjectParameter("EntBy", typeof(int));
    
            var modByParameter = modBy.HasValue ?
                new ObjectParameter("ModBy", modBy) :
                new ObjectParameter("ModBy", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("CourseInsertUpdate", idParameter, courseNameParameter, feeParameter, durationParameter, activeParameter, entByParameter, modByParameter);
        }
    
        public virtual int DeleteCourse(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteCourse", idParameter);
        }
    
        public virtual ObjectResult<getCourseById_Result> getCourseById(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getCourseById_Result>("getCourseById", idParameter);
        }
    
        public virtual ObjectResult<getCourseList_Result> getCourseList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getCourseList_Result>("getCourseList");
        }
    
        public virtual ObjectResult<getInquiryById_Result> getInquiryById(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getInquiryById_Result>("getInquiryById", idParameter);
        }
    
        public virtual ObjectResult<getInquiryList_Result> getInquiryList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getInquiryList_Result>("getInquiryList");
        }
    
        public virtual ObjectResult<Nullable<int>> InsertUpdateInquiry(Nullable<int> id, string fname, string lname, string courseID, string emailId, string mobile, string address, Nullable<int> areaId, Nullable<int> city, string preferTimeTO, string preferTimeFrom, Nullable<bool> final, string notes, Nullable<int> entBy, Nullable<int> modBy)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var fnameParameter = fname != null ?
                new ObjectParameter("fname", fname) :
                new ObjectParameter("fname", typeof(string));
    
            var lnameParameter = lname != null ?
                new ObjectParameter("lname", lname) :
                new ObjectParameter("lname", typeof(string));
    
            var courseIDParameter = courseID != null ?
                new ObjectParameter("CourseID", courseID) :
                new ObjectParameter("CourseID", typeof(string));
    
            var emailIdParameter = emailId != null ?
                new ObjectParameter("EmailId", emailId) :
                new ObjectParameter("EmailId", typeof(string));
    
            var mobileParameter = mobile != null ?
                new ObjectParameter("Mobile", mobile) :
                new ObjectParameter("Mobile", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            var areaIdParameter = areaId.HasValue ?
                new ObjectParameter("AreaId", areaId) :
                new ObjectParameter("AreaId", typeof(int));
    
            var cityParameter = city.HasValue ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(int));
    
            var preferTimeTOParameter = preferTimeTO != null ?
                new ObjectParameter("PreferTimeTO", preferTimeTO) :
                new ObjectParameter("PreferTimeTO", typeof(string));
    
            var preferTimeFromParameter = preferTimeFrom != null ?
                new ObjectParameter("PreferTimeFrom", preferTimeFrom) :
                new ObjectParameter("PreferTimeFrom", typeof(string));
    
            var finalParameter = final.HasValue ?
                new ObjectParameter("Final", final) :
                new ObjectParameter("Final", typeof(bool));
    
            var notesParameter = notes != null ?
                new ObjectParameter("Notes", notes) :
                new ObjectParameter("Notes", typeof(string));
    
            var entByParameter = entBy.HasValue ?
                new ObjectParameter("EntBy", entBy) :
                new ObjectParameter("EntBy", typeof(int));
    
            var modByParameter = modBy.HasValue ?
                new ObjectParameter("ModBy", modBy) :
                new ObjectParameter("ModBy", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("InsertUpdateInquiry", idParameter, fnameParameter, lnameParameter, courseIDParameter, emailIdParameter, mobileParameter, addressParameter, areaIdParameter, cityParameter, preferTimeTOParameter, preferTimeFromParameter, finalParameter, notesParameter, entByParameter, modByParameter);
        }
    
        public virtual ObjectResult<getAdmissionById_Result> getAdmissionById(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getAdmissionById_Result>("getAdmissionById", idParameter);
        }
    
        public virtual ObjectResult<getAdmissionList_Result> getAdmissionList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getAdmissionList_Result>("getAdmissionList");
        }
    
        public virtual int DeleteInquiry(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteInquiry", idParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> InsertUpdateAdmission(Nullable<int> id, string fname, string mname, string lname, string address, string mobileH, string mobileF, string mobileP, string email, Nullable<int> areId, string qualificationId, Nullable<int> streamId, Nullable<int> occupationId, string courseId, string schoolName, Nullable<System.DateTime> birthDate, string preferTimeTO, string preferTimeFrom, string remark, Nullable<decimal> totalFees, Nullable<int> disCount, Nullable<decimal> netFees, Nullable<int> noOfInstallment, Nullable<decimal> installment1Rs, Nullable<System.DateTime> installment1Date, Nullable<decimal> installment2Rs, Nullable<System.DateTime> installment2Date, Nullable<decimal> installment3Rs, Nullable<System.DateTime> installment3Date, Nullable<decimal> installment4Rs, Nullable<System.DateTime> installment4Date, Nullable<decimal> installment5Rs, Nullable<System.DateTime> installment5Date, Nullable<decimal> installment6Rs, Nullable<System.DateTime> installment6Date, Nullable<decimal> installment7Rs, Nullable<System.DateTime> installment7Date, Nullable<decimal> installment8Rs, Nullable<System.DateTime> installment8Date, Nullable<decimal> installment9Rs, Nullable<System.DateTime> installment9Date, Nullable<decimal> installment10Rs, Nullable<System.DateTime> installment10Date, Nullable<int> modBy, string admissionNo, string regNo, Nullable<System.DateTime> admissionDate)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var fnameParameter = fname != null ?
                new ObjectParameter("fname", fname) :
                new ObjectParameter("fname", typeof(string));
    
            var mnameParameter = mname != null ?
                new ObjectParameter("Mname", mname) :
                new ObjectParameter("Mname", typeof(string));
    
            var lnameParameter = lname != null ?
                new ObjectParameter("Lname", lname) :
                new ObjectParameter("Lname", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            var mobileHParameter = mobileH != null ?
                new ObjectParameter("MobileH", mobileH) :
                new ObjectParameter("MobileH", typeof(string));
    
            var mobileFParameter = mobileF != null ?
                new ObjectParameter("MobileF", mobileF) :
                new ObjectParameter("MobileF", typeof(string));
    
            var mobilePParameter = mobileP != null ?
                new ObjectParameter("MobileP", mobileP) :
                new ObjectParameter("MobileP", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var areIdParameter = areId.HasValue ?
                new ObjectParameter("AreId", areId) :
                new ObjectParameter("AreId", typeof(int));
    
            var qualificationIdParameter = qualificationId != null ?
                new ObjectParameter("QualificationId", qualificationId) :
                new ObjectParameter("QualificationId", typeof(string));
    
            var streamIdParameter = streamId.HasValue ?
                new ObjectParameter("StreamId", streamId) :
                new ObjectParameter("StreamId", typeof(int));
    
            var occupationIdParameter = occupationId.HasValue ?
                new ObjectParameter("OccupationId", occupationId) :
                new ObjectParameter("OccupationId", typeof(int));
    
            var courseIdParameter = courseId != null ?
                new ObjectParameter("CourseId", courseId) :
                new ObjectParameter("CourseId", typeof(string));
    
            var schoolNameParameter = schoolName != null ?
                new ObjectParameter("SchoolName", schoolName) :
                new ObjectParameter("SchoolName", typeof(string));
    
            var birthDateParameter = birthDate.HasValue ?
                new ObjectParameter("BirthDate", birthDate) :
                new ObjectParameter("BirthDate", typeof(System.DateTime));
    
            var preferTimeTOParameter = preferTimeTO != null ?
                new ObjectParameter("PreferTimeTO", preferTimeTO) :
                new ObjectParameter("PreferTimeTO", typeof(string));
    
            var preferTimeFromParameter = preferTimeFrom != null ?
                new ObjectParameter("PreferTimeFrom", preferTimeFrom) :
                new ObjectParameter("PreferTimeFrom", typeof(string));
    
            var remarkParameter = remark != null ?
                new ObjectParameter("Remark", remark) :
                new ObjectParameter("Remark", typeof(string));
    
            var totalFeesParameter = totalFees.HasValue ?
                new ObjectParameter("TotalFees", totalFees) :
                new ObjectParameter("TotalFees", typeof(decimal));
    
            var disCountParameter = disCount.HasValue ?
                new ObjectParameter("DisCount", disCount) :
                new ObjectParameter("DisCount", typeof(int));
    
            var netFeesParameter = netFees.HasValue ?
                new ObjectParameter("NetFees", netFees) :
                new ObjectParameter("NetFees", typeof(decimal));
    
            var noOfInstallmentParameter = noOfInstallment.HasValue ?
                new ObjectParameter("NoOfInstallment", noOfInstallment) :
                new ObjectParameter("NoOfInstallment", typeof(int));
    
            var installment1RsParameter = installment1Rs.HasValue ?
                new ObjectParameter("Installment1Rs", installment1Rs) :
                new ObjectParameter("Installment1Rs", typeof(decimal));
    
            var installment1DateParameter = installment1Date.HasValue ?
                new ObjectParameter("Installment1Date", installment1Date) :
                new ObjectParameter("Installment1Date", typeof(System.DateTime));
    
            var installment2RsParameter = installment2Rs.HasValue ?
                new ObjectParameter("Installment2Rs", installment2Rs) :
                new ObjectParameter("Installment2Rs", typeof(decimal));
    
            var installment2DateParameter = installment2Date.HasValue ?
                new ObjectParameter("Installment2Date", installment2Date) :
                new ObjectParameter("Installment2Date", typeof(System.DateTime));
    
            var installment3RsParameter = installment3Rs.HasValue ?
                new ObjectParameter("Installment3Rs", installment3Rs) :
                new ObjectParameter("Installment3Rs", typeof(decimal));
    
            var installment3DateParameter = installment3Date.HasValue ?
                new ObjectParameter("Installment3Date", installment3Date) :
                new ObjectParameter("Installment3Date", typeof(System.DateTime));
    
            var installment4RsParameter = installment4Rs.HasValue ?
                new ObjectParameter("Installment4Rs", installment4Rs) :
                new ObjectParameter("Installment4Rs", typeof(decimal));
    
            var installment4DateParameter = installment4Date.HasValue ?
                new ObjectParameter("Installment4Date", installment4Date) :
                new ObjectParameter("Installment4Date", typeof(System.DateTime));
    
            var installment5RsParameter = installment5Rs.HasValue ?
                new ObjectParameter("Installment5Rs", installment5Rs) :
                new ObjectParameter("Installment5Rs", typeof(decimal));
    
            var installment5DateParameter = installment5Date.HasValue ?
                new ObjectParameter("Installment5Date", installment5Date) :
                new ObjectParameter("Installment5Date", typeof(System.DateTime));
    
            var installment6RsParameter = installment6Rs.HasValue ?
                new ObjectParameter("Installment6Rs", installment6Rs) :
                new ObjectParameter("Installment6Rs", typeof(decimal));
    
            var installment6DateParameter = installment6Date.HasValue ?
                new ObjectParameter("Installment6Date", installment6Date) :
                new ObjectParameter("Installment6Date", typeof(System.DateTime));
    
            var installment7RsParameter = installment7Rs.HasValue ?
                new ObjectParameter("Installment7Rs", installment7Rs) :
                new ObjectParameter("Installment7Rs", typeof(decimal));
    
            var installment7DateParameter = installment7Date.HasValue ?
                new ObjectParameter("Installment7Date", installment7Date) :
                new ObjectParameter("Installment7Date", typeof(System.DateTime));
    
            var installment8RsParameter = installment8Rs.HasValue ?
                new ObjectParameter("Installment8Rs", installment8Rs) :
                new ObjectParameter("Installment8Rs", typeof(decimal));
    
            var installment8DateParameter = installment8Date.HasValue ?
                new ObjectParameter("Installment8Date", installment8Date) :
                new ObjectParameter("Installment8Date", typeof(System.DateTime));
    
            var installment9RsParameter = installment9Rs.HasValue ?
                new ObjectParameter("Installment9Rs", installment9Rs) :
                new ObjectParameter("Installment9Rs", typeof(decimal));
    
            var installment9DateParameter = installment9Date.HasValue ?
                new ObjectParameter("Installment9Date", installment9Date) :
                new ObjectParameter("Installment9Date", typeof(System.DateTime));
    
            var installment10RsParameter = installment10Rs.HasValue ?
                new ObjectParameter("Installment10Rs", installment10Rs) :
                new ObjectParameter("Installment10Rs", typeof(decimal));
    
            var installment10DateParameter = installment10Date.HasValue ?
                new ObjectParameter("Installment10Date", installment10Date) :
                new ObjectParameter("Installment10Date", typeof(System.DateTime));
    
            var modByParameter = modBy.HasValue ?
                new ObjectParameter("ModBy", modBy) :
                new ObjectParameter("ModBy", typeof(int));
    
            var admissionNoParameter = admissionNo != null ?
                new ObjectParameter("AdmissionNo", admissionNo) :
                new ObjectParameter("AdmissionNo", typeof(string));
    
            var regNoParameter = regNo != null ?
                new ObjectParameter("RegNo", regNo) :
                new ObjectParameter("RegNo", typeof(string));
    
            var admissionDateParameter = admissionDate.HasValue ?
                new ObjectParameter("AdmissionDate", admissionDate) :
                new ObjectParameter("AdmissionDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("InsertUpdateAdmission", idParameter, fnameParameter, mnameParameter, lnameParameter, addressParameter, mobileHParameter, mobileFParameter, mobilePParameter, emailParameter, areIdParameter, qualificationIdParameter, streamIdParameter, occupationIdParameter, courseIdParameter, schoolNameParameter, birthDateParameter, preferTimeTOParameter, preferTimeFromParameter, remarkParameter, totalFeesParameter, disCountParameter, netFeesParameter, noOfInstallmentParameter, installment1RsParameter, installment1DateParameter, installment2RsParameter, installment2DateParameter, installment3RsParameter, installment3DateParameter, installment4RsParameter, installment4DateParameter, installment5RsParameter, installment5DateParameter, installment6RsParameter, installment6DateParameter, installment7RsParameter, installment7DateParameter, installment8RsParameter, installment8DateParameter, installment9RsParameter, installment9DateParameter, installment10RsParameter, installment10DateParameter, modByParameter, admissionNoParameter, regNoParameter, admissionDateParameter);
        }
    
        public virtual int DeleteAdmission(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteAdmission", idParameter);
        }
    
        public virtual int InsertLog(string error, string url, string methodName, string innerMessage)
        {
            var errorParameter = error != null ?
                new ObjectParameter("Error", error) :
                new ObjectParameter("Error", typeof(string));
    
            var urlParameter = url != null ?
                new ObjectParameter("url", url) :
                new ObjectParameter("url", typeof(string));
    
            var methodNameParameter = methodName != null ?
                new ObjectParameter("methodName", methodName) :
                new ObjectParameter("methodName", typeof(string));
    
            var innerMessageParameter = innerMessage != null ?
                new ObjectParameter("InnerMessage", innerMessage) :
                new ObjectParameter("InnerMessage", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertLog", errorParameter, urlParameter, methodNameParameter, innerMessageParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> ExamInsertUpdate(Nullable<int> id, Nullable<int> coruserId, string examName, Nullable<int> noofQestion, Nullable<bool> active)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var coruserIdParameter = coruserId.HasValue ?
                new ObjectParameter("CoruserId", coruserId) :
                new ObjectParameter("CoruserId", typeof(int));
    
            var examNameParameter = examName != null ?
                new ObjectParameter("ExamName", examName) :
                new ObjectParameter("ExamName", typeof(string));
    
            var noofQestionParameter = noofQestion.HasValue ?
                new ObjectParameter("noofQestion", noofQestion) :
                new ObjectParameter("noofQestion", typeof(int));
    
            var activeParameter = active.HasValue ?
                new ObjectParameter("Active", active) :
                new ObjectParameter("Active", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("ExamInsertUpdate", idParameter, coruserIdParameter, examNameParameter, noofQestionParameter, activeParameter);
        }
    
        public virtual ObjectResult<getexamList_Result> getexamList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getexamList_Result>("getexamList");
        }
    
        public virtual ObjectResult<getexamById_Result> getexamById(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getexamById_Result>("getexamById", idParameter);
        }
    
        public virtual int DeleteExam(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteExam", idParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> ExamQuestionInsertUpdate(Nullable<int> id, Nullable<int> examId, string question, string option1, string option2, string option3, string option4, Nullable<short> correctAns)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var examIdParameter = examId.HasValue ?
                new ObjectParameter("ExamId", examId) :
                new ObjectParameter("ExamId", typeof(int));
    
            var questionParameter = question != null ?
                new ObjectParameter("Question", question) :
                new ObjectParameter("Question", typeof(string));
    
            var option1Parameter = option1 != null ?
                new ObjectParameter("Option1", option1) :
                new ObjectParameter("Option1", typeof(string));
    
            var option2Parameter = option2 != null ?
                new ObjectParameter("Option2", option2) :
                new ObjectParameter("Option2", typeof(string));
    
            var option3Parameter = option3 != null ?
                new ObjectParameter("Option3", option3) :
                new ObjectParameter("Option3", typeof(string));
    
            var option4Parameter = option4 != null ?
                new ObjectParameter("Option4", option4) :
                new ObjectParameter("Option4", typeof(string));
    
            var correctAnsParameter = correctAns.HasValue ?
                new ObjectParameter("CorrectAns", correctAns) :
                new ObjectParameter("CorrectAns", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("ExamQuestionInsertUpdate", idParameter, examIdParameter, questionParameter, option1Parameter, option2Parameter, option3Parameter, option4Parameter, correctAnsParameter);
        }
    
        public virtual ObjectResult<getExamQuestionByExamId_Result> getExamQuestionByExamId(Nullable<int> examId)
        {
            var examIdParameter = examId.HasValue ?
                new ObjectParameter("ExamId", examId) :
                new ObjectParameter("ExamId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getExamQuestionByExamId_Result>("getExamQuestionByExamId", examIdParameter);
        }
    
        public virtual ObjectResult<getExamQuestionListByExamQuestionId_Result> getExamQuestionListByExamQuestionId(Nullable<int> examId, Nullable<int> questionId)
        {
            var examIdParameter = examId.HasValue ?
                new ObjectParameter("ExamId", examId) :
                new ObjectParameter("ExamId", typeof(int));
    
            var questionIdParameter = questionId.HasValue ?
                new ObjectParameter("QuestionId", questionId) :
                new ObjectParameter("QuestionId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getExamQuestionListByExamQuestionId_Result>("getExamQuestionListByExamQuestionId", examIdParameter, questionIdParameter);
        }
    
        public virtual ObjectResult<getStudentexamById_Result> getStudentexamById(Nullable<int> studentId)
        {
            var studentIdParameter = studentId.HasValue ?
                new ObjectParameter("StudentId", studentId) :
                new ObjectParameter("StudentId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getStudentexamById_Result>("getStudentexamById", studentIdParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> ChkStdExamAvalable(Nullable<int> studentId, Nullable<int> examId)
        {
            var studentIdParameter = studentId.HasValue ?
                new ObjectParameter("StudentId", studentId) :
                new ObjectParameter("StudentId", typeof(int));
    
            var examIdParameter = examId.HasValue ?
                new ObjectParameter("ExamId", examId) :
                new ObjectParameter("ExamId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("ChkStdExamAvalable", studentIdParameter, examIdParameter);
        }
    
        public virtual ObjectResult<GetStdExamDetailsById_Result> GetStdExamDetailsById(Nullable<int> studentExamId)
        {
            var studentExamIdParameter = studentExamId.HasValue ?
                new ObjectParameter("StudentExamId", studentExamId) :
                new ObjectParameter("StudentExamId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetStdExamDetailsById_Result>("GetStdExamDetailsById", studentExamIdParameter);
        }
    
        public virtual ObjectResult<InsertExamStudentAttemptBystdId_Result> InsertExamStudentAttemptBystdId(Nullable<int> id, Nullable<int> studentId, Nullable<int> examId)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var studentIdParameter = studentId.HasValue ?
                new ObjectParameter("StudentId", studentId) :
                new ObjectParameter("StudentId", typeof(int));
    
            var examIdParameter = examId.HasValue ?
                new ObjectParameter("ExamId", examId) :
                new ObjectParameter("ExamId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<InsertExamStudentAttemptBystdId_Result>("InsertExamStudentAttemptBystdId", idParameter, studentIdParameter, examIdParameter);
        }
    
        public virtual ObjectResult<ChkExamFinish_Result> ChkExamFinish(Nullable<int> studentId, Nullable<int> examId)
        {
            var studentIdParameter = studentId.HasValue ?
                new ObjectParameter("StudentId", studentId) :
                new ObjectParameter("StudentId", typeof(int));
    
            var examIdParameter = examId.HasValue ?
                new ObjectParameter("ExamId", examId) :
                new ObjectParameter("ExamId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ChkExamFinish_Result>("ChkExamFinish", studentIdParameter, examIdParameter);
        }
    
        public virtual int UpdateQuestionAnswere(Nullable<int> studentExamDetailsId, Nullable<int> studentExamId, Nullable<int> questionId, Nullable<int> answer)
        {
            var studentExamDetailsIdParameter = studentExamDetailsId.HasValue ?
                new ObjectParameter("StudentExamDetailsId", studentExamDetailsId) :
                new ObjectParameter("StudentExamDetailsId", typeof(int));
    
            var studentExamIdParameter = studentExamId.HasValue ?
                new ObjectParameter("StudentExamId", studentExamId) :
                new ObjectParameter("StudentExamId", typeof(int));
    
            var questionIdParameter = questionId.HasValue ?
                new ObjectParameter("QuestionId", questionId) :
                new ObjectParameter("QuestionId", typeof(int));
    
            var answerParameter = answer.HasValue ?
                new ObjectParameter("Answer", answer) :
                new ObjectParameter("Answer", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateQuestionAnswere", studentExamDetailsIdParameter, studentExamIdParameter, questionIdParameter, answerParameter);
        }
    
        public virtual ObjectResult<GetStdUPdateQuestionAnswereById_Result> GetStdUPdateQuestionAnswereById(Nullable<int> studentExamDetailsId)
        {
            var studentExamDetailsIdParameter = studentExamDetailsId.HasValue ?
                new ObjectParameter("StudentExamDetailsId", studentExamDetailsId) :
                new ObjectParameter("StudentExamDetailsId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetStdUPdateQuestionAnswereById_Result>("GetStdUPdateQuestionAnswereById", studentExamDetailsIdParameter);
        }
    
        public virtual ObjectResult<getStudentExamResultbyStdExamId_Result> getStudentExamResultbyStdExamId(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getStudentExamResultbyStdExamId_Result>("getStudentExamResultbyStdExamId", idParameter);
        }
    
        public virtual int updateStudentExam(Nullable<int> id, Nullable<int> studentId, Nullable<int> examId)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var studentIdParameter = studentId.HasValue ?
                new ObjectParameter("StudentId", studentId) :
                new ObjectParameter("StudentId", typeof(int));
    
            var examIdParameter = examId.HasValue ?
                new ObjectParameter("ExamId", examId) :
                new ObjectParameter("ExamId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updateStudentExam", idParameter, studentIdParameter, examIdParameter);
        }
    
        public virtual ObjectResult<viewResultByStdId_Result> viewResultByStdId(Nullable<int> studentId, Nullable<int> examId)
        {
            var studentIdParameter = studentId.HasValue ?
                new ObjectParameter("StudentId", studentId) :
                new ObjectParameter("StudentId", typeof(int));
    
            var examIdParameter = examId.HasValue ?
                new ObjectParameter("examId", examId) :
                new ObjectParameter("examId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<viewResultByStdId_Result>("viewResultByStdId", studentIdParameter, examIdParameter);
        }
    
        public virtual int ExamCopyQuestion(Nullable<int> fromExamid, Nullable<int> toExamId)
        {
            var fromExamidParameter = fromExamid.HasValue ?
                new ObjectParameter("fromExamid", fromExamid) :
                new ObjectParameter("fromExamid", typeof(int));
    
            var toExamIdParameter = toExamId.HasValue ?
                new ObjectParameter("toExamId", toExamId) :
                new ObjectParameter("toExamId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ExamCopyQuestion", fromExamidParameter, toExamIdParameter);
        }
    
        public virtual int DataBaseBackUp()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DataBaseBackUp");
        }
    
        public virtual ObjectResult<getExamQuestionListByExamId_Result> getExamQuestionListByExamId(Nullable<int> examId)
        {
            var examIdParameter = examId.HasValue ?
                new ObjectParameter("ExamId", examId) :
                new ObjectParameter("ExamId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getExamQuestionListByExamId_Result>("getExamQuestionListByExamId", examIdParameter);
        }
    }
}
