using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bal;
using dal.edmx;
using System.Data.Entity;

namespace dal
{
    public class DalComman
    {
        public void Loginsert(string url, string method, string error, string innermgs)
        {
            try
            {
                using (aspccEntities db = new aspccEntities())
                {
                    db.InsertLog(error, url, method, innermgs);
                }

            }
            catch (Exception ex)
            {
               
            }

        }

        public void DataBaseBackUp(string dbpath)
        {
            try
            {
                
                using (aspccEntities db = new aspccEntities())
                {
                    db.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, @"DECLARE @DBName NVARCHAR(max); SET @DBName = 'aspcc ' + CONVERT(nvarchar(50), getdate(), 113) + '.bak'; SET @DBName = '"+ dbpath + "\\'+REPLACE(REPLACE(@DBName,' ',''),':',''); BACKUP DATABASE aspcc TO  DISK = @DBName WITH NOFORMAT, INIT, NAME = N'aspcc Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10");
                }

            }
            catch (Exception ex)
            {

            }

        }
    }
}
