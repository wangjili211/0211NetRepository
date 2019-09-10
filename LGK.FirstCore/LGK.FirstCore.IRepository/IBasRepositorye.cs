using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using LGK.FirstCore.Model;

namespace LGK.FirstCore.IRepository
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        /// <summary>
        /// 获取数据集合
        /// </summary>
        DbSet<T> Entities { get; }

        //显示
        List<T> GetRole();



        /// <summary>
        /// 增加单个实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// 

        int Insert(T entity);

    //增加多个实体
    int Insert(IEnumerable<T> entities);

    /// <summary>
    /// 更新实体
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    int Update(T entity);

    /// <summary>
    /// 删除
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    int Delete(object id);

    /// <summary>
    /// 根据逐渐获取实体
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    T GetModelById(object key);
}
}
