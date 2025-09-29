using Microsoft.EntityFrameworkCore;
using FreeCodeCamp_ASP.NET_MVCTutorial.Models;

namespace FreeCodeCamp_ASP.NET_MVCTutorial.Data
{
    public class FinanceAppContext : DbContext
    {
        public FinanceAppContext(DbContextOptions<FinanceAppContext> options) :base(options){ }



        public DbSet<Expense> Expenses { get; set; }
    }
}
