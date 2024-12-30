using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVC_EF_Code_First.Models;

namespace MVC_EF_Code_First.Repository
{
    public class ProductRepository<T> : IProductRepository<T> where T : class
    {
        ProductsContext db;
        DbSet<T> dbset;

        public ProductRepository()
        {
            db = new ProductsContext();
            dbset = db.Set<T>();
        }
        public void Delete(object Id)
        {
            T getModel = dbset.Find(Id);
            dbset.Remove(getModel);
        }

        public IEnumerable<T> GetAll()
        {
            return dbset.ToList();
        }

        public T GetById(object Id)
        {
            return dbset.Find(Id);
        }

        public void Insert(T obj)
        {
            dbset.Add(obj);

        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(T obj)
        {
            db.Entry(obj).State = EntityState.Modified;
        }
    }
}