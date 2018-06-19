using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bal;
using dal.edmx;
namespace dal
{
    public class DallStudentOpration
    {
        public bal.balComman com = new balComman();

        public List<ChkExamFinish_Result> checkExamFinish(int studentid, int examid)
        {
            try
            {
                List<ChkExamFinish_Result> ExamDetailslist = new List<ChkExamFinish_Result>();
                using (aspccEntities db = new aspccEntities())
                {
                    ExamDetailslist = db.ChkExamFinish(studentid, examid).ToList();
                    return ExamDetailslist;
                }
            }
            catch (Exception ex)
            {
                com.Loginsert("DalcheckExamFinish", "checkExamFinish", ex.StackTrace, ex.Message);
                return null;
            }
        }

        public InsertExamStudentAttemptBystdId_Result InsertExamStudentAttemptBystdId(int? id, int studentid, int examid)
        {
            try
            {
                using (aspccEntities db = new aspccEntities())
                {
                    InsertExamStudentAttemptBystdId_Result StudentExamID = new InsertExamStudentAttemptBystdId_Result();
                    StudentExamID = db.InsertExamStudentAttemptBystdId(id, studentid, examid).FirstOrDefault();
                    return StudentExamID;
                }
            }
            catch (Exception ex)
            {
                com.Loginsert("DalInsertExamStudentAttemptBystdId", "InsertExamStudentAttemptBystdId", ex.StackTrace, ex.Message);
                return null;
            }
        }

        public List<GetStdExamDetailsById_Result> GetStdExamDetailsById(int? StudentExamId)
        {
            try
            {
                using (aspccEntities db = new aspccEntities())
                {
                    List<GetStdExamDetailsById_Result> StudentExamDetails = new List<GetStdExamDetailsById_Result>();
                    StudentExamDetails = db.GetStdExamDetailsById(StudentExamId).ToList();
                    return StudentExamDetails;
                }
            }
            catch (Exception ex)
            {
                com.Loginsert("DalcheckExamFinish", "checkExamFinish", ex.StackTrace, ex.Message);
                return null;
            }
        }
             
        public int UpdateQuestionAnswere(int StudentExamDetailsId, int StudentExamId, int QuestionId, int Answer)
        {
            try
            {
                using (aspccEntities db = new aspccEntities())
                {
                    db.UpdateQuestionAnswere(StudentExamDetailsId, StudentExamId, QuestionId, Answer);
                    return 1;
                }
            }
            catch (Exception ex)
            {
                com.Loginsert("DALUpdateQuestionAnswere", "UpdateQuestionAnswere", ex.StackTrace, ex.Message);
                return 0;
            }
        }

        public GetStdUPdateQuestionAnswereById_Result GetStdUPdateQuestionAnswereById(int StudentExamDetailsId) {
            try
            {
                using (aspccEntities db = new aspccEntities())
                {
                    GetStdUPdateQuestionAnswereById_Result questiodetails = new GetStdUPdateQuestionAnswereById_Result();
                    questiodetails = db.GetStdUPdateQuestionAnswereById(StudentExamDetailsId).FirstOrDefault();
                    return questiodetails;
                }
            }
            catch (Exception ex)
            {
                com.Loginsert("DalGetStdUPdateQuestionAnswereById", "GetStdUPdateQuestionAnswereById", ex.StackTrace, ex.Message);
                return null;
            }
        }

        public void updateStudentExam(int Id, int StudentExamId, int QuestionId)
        {
            try
            {
                using (aspccEntities db = new aspccEntities())
                {
                    db.updateStudentExam(Id, StudentExamId, QuestionId);
                }
            }
            catch (Exception ex)
            {
                com.Loginsert("DalupdateStudentExam", "updateStudentExam", ex.StackTrace, ex.Message);
            }
        }

        public List<getStudentExamResultbyStdExamId_Result> getStudentExamResultbyStdExamId(int Id)
        {
            try
            {
                using (aspccEntities db = new aspccEntities())
                {
                    List<getStudentExamResultbyStdExamId_Result> StudentExamrresultDetails = new List<getStudentExamResultbyStdExamId_Result>();
                    StudentExamrresultDetails = db.getStudentExamResultbyStdExamId(Id).ToList();
                    return StudentExamrresultDetails;
                }
            }
            catch (Exception ex)
            {
                com.Loginsert("DalgetStudentExamResultbyStdExamId", "getStudentExamResultbyStdExamId", ex.StackTrace, ex.Message);
                return null;
            }
        }

        public List<viewResultByStdId_Result> viewResultByStdId(int StudentId, int Examid)
        {
            try
            {
                using (aspccEntities db = new aspccEntities())
                {
                    List<viewResultByStdId_Result> viewResult = new List<viewResultByStdId_Result>();
                    viewResult = db.viewResultByStdId(StudentId, Examid).ToList();
                    return viewResult;
                }
            }
            catch (Exception ex)
            {
                com.Loginsert("DalviewResultByStdId", "viewResultByStdId", ex.StackTrace, ex.Message);
                return null;
            }
        }
    }
}
