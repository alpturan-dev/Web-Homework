using System;
using Microsoft.EntityFrameworkCore;
using Web_Homework.Models;

namespace Web_Homework.Repositories
{
	public class GenericRepository<Table> where Table:class
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
        public void DeletePerson(Table parameter)
        {
            context.Set<Table>().Remove(parameter);
            context.SaveChanges();
        }
        public void UpdatePerson(Table parameter)
        {
            context.Set<Table>().Update(parameter);
            context.SaveChanges();
        }
        public void FindPerson(int id)
        {
            context.Set<Table>().Find(id);
        }
    }
}

