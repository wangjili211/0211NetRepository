using LGK.FirstCore.IRepository;
using LGK.FirstCore.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LGK.FirstCore.Repository
{
    public abstract class BaseRepository<Role> : IBaseRepository<Role> where Role : BaseEntity
    {
        DataContext EF = new DataContext();
        public DbSet<Role> Entities
        {
            get { return EF.Set<Role>(); }
        }



        public int Insert(Role entity)
        {
            Entities.Add(entity);
            var i = EF.SaveChanges();
            return i;
        }

        public int Insert(IEnumerable<Role> entities)
        {
            Entities.AddRange(entities);
            return EF.SaveChanges();
        }

        public int Update(Role entity)
        {
            EF.Entry(entity).State = EntityState.Modified;
            return EF.SaveChanges();
        }

        public int Delete(object id)
        {
            ///删除操作实现
            var obj = Entities.Find(id);
            Entities.Remove(obj);
            return EF.SaveChanges();
        }

        public Role GetModelById(object key)
        {
            var obj = Entities.Find(key);
            return obj;
        }


        /// <summary>
        /// 显示分页查询
        /// </summary>
        /// <param name="pageindex"></param>
        /// <param name="pagesize"></param>
        /// <returns></returns>
        //public PageModel<Role> GetPage(int pageindex, int pagesize)
        //{

        //}

        //public PageModel<Role> IBaseRepository<Role>.GetPage(int pageindex, int pagesize)
        //{
           
        //}

        public PageModelFirst<Role> GetPage(int pageindex, int pagesize)
        {
            PageModel<Role> pd = new PageModel<Role>();

            using (DataContext db = new DataContext())
            {
                pd.Data = db.Role.Skip((pageindex - 1) * pagesize).Take(pagesize).ToList();
                int count = db.Role.Count();
                pd.RountCount = Convert.ToInt32(Math.Ceiling((decimal)count / pagesize));
            }
            return pd;
        }
    }
}
