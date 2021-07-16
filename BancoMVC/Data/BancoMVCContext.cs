using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BancoMVC.Models;

namespace BancoMVC.Data
{
    public class BancoMVCContext : DbContext
    {
        public BancoMVCContext (DbContextOptions<BancoMVCContext> options)
            : base(options)
        {
        }

        public DbSet<BancoMVC.Models.Clientes> Clientes { get; set; }
    }
}
