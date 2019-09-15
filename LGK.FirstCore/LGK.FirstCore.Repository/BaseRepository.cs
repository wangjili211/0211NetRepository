using LGK.FirstCore.IRepository;
using LGK.FirstCore.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LGK.FirstCore.Repository
{
    public abstract class BaseRepository<T> : IBasRepositorye<T> where T : BaseEntity
    {
        DataContext EF = new DataContext();
        public DbSet<T> Entities
        {
            get { return EF.Set<T>(); }
        }

        public int Insert(T entity)
        {
            Entities.Add(entity);
            var i = EF.SaveChanges();
            return i;
        }

        public int Insert(IEnumerable<T> entities)
        {
            Entities.AddRange(entities);
            return EF.SaveChanges();
        }    

        public int Update(T entity)
        {
            EF.Entry(entity).State = EntityState.Modified;
            return EF.SaveChanges();
        }

        public int Delete(int id)
        {
            ///删除操作实现
            var obj = Entities.Find(id);
            Entities.Remove(obj);
            return EF.SaveChanges();
        }

        public T GetModelById(object key)
        {
            var obj = Entities.Find(key);
            return obj;
        }
        
        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public List<T> GetRole()
        {
            var list = Entities.ToList();
            return list;
        }
    }

}
