using DesignPattern_ChainOfResponsibility_1.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern_ChainOfResponsibility_1.DAL.Context
{
    public class ChainOfRespContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-JNJNVEQ\\MERTSQL; initial Catalog=DbChainOfResponsibility;integrated Security=true");
        }
        public DbSet<CustomerProccess> CustomerProccesses { get; set; }

    }
}
