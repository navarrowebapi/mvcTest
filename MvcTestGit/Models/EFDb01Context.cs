using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcTestGit.Models
{
    public class EfDb01Context : DbContext
    {
        public DbSet<Product> Produtos { get; set; }

    }
}