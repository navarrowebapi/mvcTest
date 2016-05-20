using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using MvcTestGit.Models;

namespace MvcTestGit.DAL
{
    public class DbInitializer : DropCreateDatabaseIfModelChanges<EfDb01Context>
    {
        protected override void Seed(EfDb01Context context)
        {
            var listaDeProdutos = new List<Product>
            { 
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 }, 
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M }, 
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M } 
            };

            listaDeProdutos.ForEach(x => context.Produtos.Add(x));
            context.SaveChanges();
        }
    }
}