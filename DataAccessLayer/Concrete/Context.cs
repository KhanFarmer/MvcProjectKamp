using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context :DbContext 
    {
        public DbSet<About> abouts { get; set; }
        public DbSet<Category> categories{ get; set; }
        public DbSet<Contact> contacts { get; set; }
        public DbSet<Content> contents{ get; set; }
        public DbSet<Heading> Headings{ get; set; }
        public DbSet<Writer> writers{ get; set; }

    }
}
