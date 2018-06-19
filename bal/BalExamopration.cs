using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dal;
using dal.edmx;

namespace bal
{
    public class BalExamopration
    {
        public dal.Dallexamopration Exameop = new dal.Dallexamopration();

        #region Exam
        public int ExamInsertUpdate(clsExam objExam)
        {
            return Exameop.ExamInsertUpdate(objExam);
        }
        public List<getexamList_Result> GetexamList()
        {
            return Exameop.GetexamList();
        }
        public getexamById_Result GetexamById(int? id)
        {
            return Exameop.GetexamById(id);
        }
        public void Deletetexam(int id)
        {
            Exameop.Deleteexam(id);
        }
        #endregion
        #region ExamExamQuestion
        public int ExamQuestionInsertUpdate(clsExamQuestionOp objExamQuestionOp)
        {
            return Exameop.ExamQuestionInsertUpdate(objExamQuestionOp);
        }
        public List<getExamQuestionListByExamId_Result> getExamQuestionListByExamId(int ExamId)
        {
            return Exameop.getExamQuestionListByExamId(ExamId);
        }

        public getExamQuestionListByExamQuestionId_Result getExamQuestionListByExamQuestionId(int ExamId, int QuestionId)
        {
            return Exameop.getExamQuestionListByExamQuestionId(ExamId, QuestionId);
        }

        #endregion

        #region ExamStudentQuestion
        public List<getStudentexamById_Result> getStudentexamById(int id)
        {
            return Exameop.getStudentexamById(id);
        }
        #endregion

        public void CopyExam(int fromid, int toid)
        {
            Exameop.CopyExam(fromid, toid);
        }
    }
}
