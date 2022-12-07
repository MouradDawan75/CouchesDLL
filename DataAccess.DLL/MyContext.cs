using Core.DLL.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace DataAccess.DLL
{
    public class MyContext : DbContext
    {
  
        public MyContext()
            : base("name=MyContext")
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}