using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess2
{
    public class DatabaseRepository
    {
        SA10_Monitor_DatabaseEntities3 db = new SA10_Monitor_DatabaseEntities3();

        public IQueryable<Software> GetAllDatabase()
        {
            return db.Softwares;
        }
        public IQueryable<Software> GetAllDatabase(string id)
        {
            return db.Softwares.Where(a => a.AssetID == id).Select(e => e);
        }
    }
}
