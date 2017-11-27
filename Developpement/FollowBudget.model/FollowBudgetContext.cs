using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FollowBudget.model
{
    public class FollowBudgetContext : DbContext
    {
        public FollowBudgetContext() : base("name=FollowBudgetConnectionString")
        {
            Database.SetInitializer<FollowBudgetContext>(new FollowBudgetDBInitializer<FollowBudgetContext>());
            Database.Create();
        }
        
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Income> Incomes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().HasKey<int>(account => account.ID)
                .ToTable("Accounts");

            modelBuilder.Entity<Account>().Property(p => p.Name).HasColumnName("Name")
                .IsRequired();

            modelBuilder.Entity<Income>().HasKey<int>(income => income.ID)
                .ToTable("Incomes");

            base.OnModelCreating(modelBuilder);
        }
    }
}
