using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace tracker_expense.Models
{
    public class Expense
    {
        public int Id { get; set; }
        
        public decimal Value { get; set; }

        [Required ]
        public string? Description { get; set; }
    }
}
