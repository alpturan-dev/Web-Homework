using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Web_Homework.Models;

namespace Web_Homework.Repositories
{
    public class GenericRepository<Table> where Table : class
    {
        Context context = new Context();
        public List<Table> TableList()
        {
            return context.Set<Table>().ToList();
        }
        public List<Table> TableList(string parameter)
        {
            return context.Set<Table>().Include(parameter).ToList();
        }
        public void AddTable(Table parameter)
        {
            context.Set<Table>().Add(parameter);
            context.SaveChanges();
        }
        public void DeleteTable(Table parameter)
        {
            context.Set<Table>().Remove(parameter);
            context.SaveChanges();
        }
        public void UpdateTable(Table parameter)
        {
            context.Set<Table>().Update(parameter);
            context.SaveChanges();
        }
        public Table FindTable(int id)
        {
            return context.Set<Table>().Find(id);
        }
        public List<Table> FilteredTable(Expression<Func<Table, bool>> filtered)
        {
            return context.Set<Table>().Where(filtered).ToList();
        }
    }
}

