using System.Collections.Generic;
using System;
using DemoApi31.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Web.Http.ModelBinding;

namespace DemoApi31.Repository
{
    public class MainRepository<T>:MainInterface<T> where T : class
    {

        private readonly AppDbContext _db;

        public MainRepository(AppDbContext db)
        {
            _db = db;
        }

       // public T AddRow(T model)
        public void AddRow(T model)
        {
            _db.Set<T>().Add(model);
            _db.SaveChanges();
           // return model ;
        }

        public void DeleteRow(int id)
        {  
            
          
            var model = GetRowId(id);
            _db.Set<T>().Remove(model);
            _db.SaveChanges();
        }

        public IEnumerable<T> GetAllDate()
        {
           
            return _db.Set<T>().ToList();

        }

        public T GetRowId(int id)
        {
            
            return _db.Set<T>().Find(id);
        }

        #region
        //public void UpdateRow(T modle)
        //{
        //    _db.Set<T>().Update(modle);
        //    _db.SaveChanges();
        //}

        //public T UpdateRow(T modle)
        //{
        //    DbSet<T> ts = _db.Set<T>();
        //    ts.Attach(modle);
        //    _db.Entry(modle).State = EntityState.Modified;
        //    _db.SaveChanges();
        //    return modle;
        //}
        #endregion

        void MainInterface<T>.UpdateRow(T modle)
        {
            
            _db.Entry(modle).State = EntityState.Modified;
            _db.SaveChanges();
        }
    }
}
