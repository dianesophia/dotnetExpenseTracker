﻿using Microsoft.EntityFrameworkCore;

namespace tracker_expense.Models
{
    public class ExpensesDbContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }
        public ExpensesDbContext(DbContextOptions<ExpensesDbContext> options)
            :base(options)
        {
           
        }

    }
}
//