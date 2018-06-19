using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dal;
using dal.edmx;
namespace bal
{
    public class BalStudentOpration
    {
        public dal.DallStudentOpration Studentop = new dal.DallStudentOpration();
        public List<ChkExamFinish_Result> checkExamFinish(int studentid, int examid)
        {
            return Studentop.checkExamFinish(studentid, examid);
        }
        public InsertExamStudentAttemptBystdId_Result InsertExamStudentAttemptBystdId(int? id, int studentid, int examid)
        {
            return Studentop.InsertExamStudentAttemptBystdId(id, studentid, examid);
        }
        public List<GetStdExamDetailsById_Result> GetStdExamDetailsById(int? StudentExamId)
        {
            return Studentop.GetStdExamDetailsById(StudentExamId);
        }

        public int UpdateQuestionAnswere(int StudentExamDetailsId, int StudentExamId, int QuestionId, int Answer)
        {
            return Studentop.UpdateQuestionAnswere(StudentExamDetailsId, StudentExamId, QuestionId, Answer);
        }

        public GetStdUPdateQuestionAnswereById_Result GetStdUPdateQuestionAnswereById(int StudentExamDetailsId)
        {
            return Studentop.GetStdUPdateQuestionAnswereById(StudentExamDetailsId);
        }
        public void updateStudentExam(int Id, int StudentExamId, int QuestionId)
        {
            Studentop.updateStudentExam(Id, StudentExamId, QuestionId);
        }
        public List<getStudentExamResultbyStdExamId_Result> getStudentExamResultbyStdExamId(int Id)
        {
            return Studentop.getStudentExamResultbyStdExamId(Id);
        }
        public List<viewResultByStdId_Result> viewResultByStdId(int StudentId,int examid)
        {
            return Studentop.viewResultByStdId(StudentId, examid);
        }
    }
}
