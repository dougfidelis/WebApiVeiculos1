using Data.Context;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : BaseModel
    {

        public virtual string Create(T model)
        {
            using (MyContext context = new MyContext())
            {
                context.Set<T>().Add(model);
                context.SaveChanges();

            }
            return "Created";

        }
        public virtual T GetById(int id)
        {
            T model = null;
            using (MyContext context = new MyContext())
            {
                model = context.Set<T>().Find(id);
            }
            return model;
        }

        public virtual string Delete(int id)
        {
            using (MyContext context = new MyContext())
            {
                context.Entry(this.GetById(id)).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                context.SaveChanges();
            }
            return "Deleted";
        }

        public virtual List<T> GetAll()
        {
            List<T> entities = new List<T>();
            using (MyContext context = new MyContext())
            {
                entities = context.Set<T>().ToList();
            }
            return entities;
        }


        public virtual string Update(T model)
        {
            using (MyContext context = new MyContext())
            {
                context.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }
            return "Modified";
        }
    }
}
