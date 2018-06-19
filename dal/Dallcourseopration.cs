using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bal;
using dal.edmx;

namespace dal
{
    public class Dallcourseopration
    {


        public int CourseInsertUpdate(clsCourse objcourse)
        {
            try
            {
                using (aspccEntities db = new aspccEntities())
                {
                    var result = db.CourseInsertUpdate(objcourse.Id, objcourse.CourseName, objcourse.Fee, objcourse.Duration, objcourse.Active, 1, 1);
                     //return Convert.ToInt32(result.FirstOrDefault());
                    return 1;
                }

            }
            catch (Exception ex)
            {
                return 0;

            }

        }

        public List<getCourseList_Result> GetCourseList() {

            try
            {
                List<getCourseList_Result> courselist = new List<getCourseList_Result>();
                using (aspccEntities db = new aspccEntities())
                {
                    courselist = db.getCourseList().ToList();
                    return courselist;
                }

            }
            catch (Exception ex)
            {
                return null;

            }
        }

        public void DeleteCourse(int id)
        {
            try
            {
                using (aspccEntities db = new aspccEntities())
                {
                    db.DeleteCourse(id);
                 
                }
            }
            catch (Exception ex)
            {
                    
            }
        }
        public getCourseById_Result GetCourseById(int? id)
        {
            try
            {
                getCourseById_Result objcourse = new getCourseById_Result();
                using (aspccEntities db = new aspccEntities())
                {
                    objcourse = db.getCourseById(id).FirstOrDefault();
                    return objcourse;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }


    }
}
