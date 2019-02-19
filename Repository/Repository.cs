﻿using DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Repository<TEntity, Context> : IRepository<TEntity>
        where TEntity : class, new()
        where Context : LinkedInContext
    {
        private Context context;
        DbSet<TEntity> set;
        public Repository(Context context)
        {
            this.context = context;
            set = context.Set<TEntity>();
        }

        public TEntity Add(TEntity entity)
        { 
            set.Add(entity);
            return context.SaveChanges() > 0 ? entity : null;
        }

        public List<TEntity> GetAll()
        {
            return context.Set<TEntity>().ToList();
        }

        public List<TEntity> GetById(params object[] id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(TEntity entity)
        {
            set.Remove(entity);
            return context.SaveChanges() > 0;
        }

        public bool Update(TEntity entity)
        {
            set.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            return context.SaveChanges() > 0;
        }
    }

}
