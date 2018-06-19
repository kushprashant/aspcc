using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bal;
using dal.edmx;

namespace dal
{
   public class Dallexamopration
    {
        public bal.balComman com = new balComman();
        #region Exam
        public int ExamInsertUpdate(clsExam objExam)
        {
            try
            {
                using (aspccEntities db = new aspccEntities())
                {
                    var result = db.ExamInsertUpdate(objExam.Id,objExam.CoruserId,objExam.Name, objExam.noofQestion, objExam.Isactive);
                    return 1;
                }

            }
            catch (Exception ex)
            {
                com.Loginsert("DalExamInsertUpdate", "ExamInsertUpdate", ex.StackTrace, ex.Message);
                return 0;

            }

        }
        public List<getexamList_Result> GetexamList()
        {

            try
            {
                List<getexamList_Result> Examlist = new List<getexamList_Result>();
                using (aspccEntities db = new aspccEntities())
                {
                    Examlist = db.getexamList().ToList();
                    return Examlist;
                }

            }
            catch (Exception ex)
            {
                com.Loginsert("DalGetexamList", "GetexamList", ex.StackTrace, ex.Message);
                return null;

            }
        }
        public getexamById_Result GetexamById(int? id)
        {
            try
            {
                getexamById_Result objexam = new getexamById_Result();
                using (aspccEntities db = new aspccEntities())
                {
                    objexam = db.getexamById(id).FirstOrDefault();
                    return objexam;
                }
            }
            catch (Exception ex)
            {
                com.Loginsert("DalGetexamById", "GetexamById", ex.StackTrace, ex.Message);
                return null;
            }
        }
        public void Deleteexam(int id)
        {
            try
            {
                using (aspccEntities db = new aspccEntities())
                {
                    db.DeleteExam(id);

                }
            }
            catch (Exception ex)
            {
                com.Loginsert("DalDeleteexam", "Deleteexam", ex.StackTrace, ex.Message);
            }
        }
        #endregion

        #region ExamQuestion
        public int ExamQuestionInsertUpdate(clsExamQuestionOp objExamQuestionOp)
        {
            try
            {
                using (aspccEntities db = new aspccEntities())
                {
                    var result = db.ExamQuestionInsertUpdate(objExamQuestionOp.Id, objExamQuestionOp.ExamId, objExamQuestionOp.Question, objExamQuestionOp.Option1, objExamQuestionOp.Option2, objExamQuestionOp.Option3, objExamQuestionOp.Option4, objExamQuestionOp.CorrectAns);
                    return 1;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public List<getExamQuestionListByExamId_Result> getExamQuestionListByExamId(int ExamId)
        {
            try
            {
                List<getExamQuestionListByExamId_Result> ExamQuestion = new List<getExamQuestionListByExamId_Result>();
                using (aspccEntities db = new aspccEntities())
                {
                    ExamQuestion = db.getExamQuestionListByExamId(ExamId).ToList();
                    return ExamQuestion;
                }

            }
            catch (Exception ex)
            {
                com.Loginsert("DalExamQuestionInsertUpdate", "getExamQuestionListByExamId", ex.StackTrace, ex.Message);
                return null;
            }
        }
        public getExamQuestionListByExamQuestionId_Result getExamQuestionListByExamQuestionId(int ExamId, int QuestionId)
        {
            try
            {
                getExamQuestionListByExamQuestionId_Result objexam = new getExamQuestionListByExamQuestionId_Result();
                using (aspccEntities db = new aspccEntities())
                {
                    objexam = db.getExamQuestionListByExamQuestionId(ExamId, QuestionId).FirstOrDefault();
                    return objexam;
                }
            }
            catch (Exception ex)
            {
                com.Loginsert("DalgetExamQuestionListByExamQuestionId", "getExamQuestionListByExamQuestionId", ex.StackTrace, ex.Message);
                return null;
            }
        }
        #endregion

        #region ExamStudentQuestion
        public List<getStudentexamById_Result> getStudentexamById(int id)
        {

            try
            {
                List<getStudentexamById_Result> ExamStulist = new List<getStudentexamById_Result>();
                using (aspccEntities db = new aspccEntities())
                {
                    ExamStulist = db.getStudentexamById(id).ToList();
                    return ExamStulist;
                }

            }
            catch (Exception ex)
            {
                com.Loginsert("DalgetStudentexamById", "getStudentexamById", ex.StackTrace, ex.Message);
                return null;

            }
        }
        #endregion

        #region ExamStudentQuestion
        public void CopyExam(int fromid, int toid) {
            try
            {
                
                using (aspccEntities db = new aspccEntities())
                {
                    db.ExamCopyQuestion(fromid, toid);
                }

            }
            catch (Exception ex)
            {
                com.Loginsert("DalgetStudentexamById", "CopyExam", ex.StackTrace, ex.Message);
               

            }
        }
        #endregion
    }
}
