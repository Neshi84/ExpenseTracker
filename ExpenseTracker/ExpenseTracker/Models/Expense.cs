using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTracker.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public DateTime ExpenseDate { get; set; }
        public ExpenseType ExpenseType { get; set; }
        public Bussines Bussines { get; set; }
    }
}
