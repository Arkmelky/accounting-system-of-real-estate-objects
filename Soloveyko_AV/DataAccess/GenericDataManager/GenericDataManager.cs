using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.Factory;
using DataAccess.GenericDataManager;

namespace DataAccess.GenericDataManager
{
    public  abstract class BasicEntity
    {
        public int ID { get; set; }}
    }


    public class GenericDataManager<TEntity> where TEntity :  BasicEntity
    {
        
        private DB_Context dbContext;

        public TEntity Get(int id)
        {
            return dbContext.Set<TEntity>().Find(id);
        }

        public void Add(TEntity obj)
        {
            dbContext = DatabaseContextHelper.GetDbContext();
            dbContext.Set<TEntity>().Add(obj);
            DatabaseContextHelper.SaveChanges();
            DatabaseContextHelper.Dispose();
        }

        public void Delete(TEntity obj)
        {
            dbContext = DatabaseContextHelper.GetDbContext();
            dbContext.Set<TEntity>().Remove(obj);
            DatabaseContextHelper.SaveChanges();
            DatabaseContextHelper.Dispose();
        }

        public void Update(TEntity obj, int id)
        {
            
            dbContext = DatabaseContextHelper.GetDbContext();
            foreach (var o in dbContext.Set<TEntity>())
            {
                if (o.ID == obj.ID)
                {
                    //o;
                }

                DatabaseContextHelper.SaveChanges();
            DatabaseContextHelper.Dispose();
        }

    }
}
