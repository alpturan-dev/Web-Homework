using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Web_Homework.Models;

namespace Web_Homework.Repositories
{
    public class GenericRepository<Table> where Table : class
    {
        private readonly Context _context = new Context();

        public GenericRepository()
        {

        }
        public List<Table> TableList()
        {
            return _context.Set<Table>().ToList();
        }
        public List<Table> TableList(string parameter)
        {
            return _context.Set<Table>().Include(parameter).ToList();
        }
        public void AddTable(Table parameter)
        {
            _context.Set<Table>().Add(parameter);
            _context.SaveChanges();
        }
        public void DeleteTable(Table parameter)
        {
            _context.Set<Table>().Remove(parameter);
            _context.SaveChanges();
        }
        public void UpdateTable(Table parameter)
        {
            _context.Set<Table>().Update(parameter);
            _context.SaveChanges();
        }
        public Table FindTable(int id)
        {
            return _context.Set<Table>().Find(id);
        }
        public List<Table> FilteredTable(Expression<Func<Table, bool>> filtered)
        {
            return _context.Set<Table>().Where(filtered).ToList();
        }
    }
}

