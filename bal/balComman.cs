using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dal;
using dal.edmx;
namespace bal
{
   
    public class balComman
    {
        public dal.DalComman com = new dal.DalComman();
        public void Loginsert(string url, string method, string error, string innermgs)
        {
            com.Loginsert(url, method, error, innermgs);
        }

        public void DataBaseBackUp()
        {
            com.DataBaseBackUp();
        }
    }
}
