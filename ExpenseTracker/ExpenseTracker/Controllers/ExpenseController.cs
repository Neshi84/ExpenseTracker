using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTracker.Controllers
{
    public class ExpenseController : ControllerBase
    {
        [HttpGet("api/expense")]
        public IActionResult Expense()
        {
            return Ok(new { ekspense = "Test"});
        }
    }
}
