using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Factory
{
    public class DatabaseContextHelper : IDisposable
    {
        private static DB_Context dbContext;

        private DatabaseContextHelper()
        {
            dbContext = new DB_Context();
        }

        public static DB_Context GetDbContext()
        {
            return new DB_Context();
        }

        public static void SaveChanges()
        {
            dbContext.SaveChanges();
        }

        public static void Dispose()
        {
            dbContext.Dispose();
        }

        void IDisposable.Dispose()
        {
            Dispose();
        }
    }
}
