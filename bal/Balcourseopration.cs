using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dal;
using dal.edmx;

namespace bal
{
    public class courseopration
    {
        public dal.Dallcourseopration courseop = new dal.Dallcourseopration();
        public int CourseInsertUpdate(clsCourse objcourse)
        {

            return courseop.CourseInsertUpdate(objcourse);
        }
        public List<getCourseList_Result> GetCourseList()
        {
            return courseop.GetCourseList();
        }
        public void DeleteCourse(int id)
        {
            courseop.DeleteCourse(id);
        }
        public getCourseById_Result GetCourseById(int? id)
        {
            return courseop.GetCourseById(id);
        }
    }
}
