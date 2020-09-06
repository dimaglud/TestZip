using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestProject.WebAPI.Data.Entities
{
    public class User
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public double MonthlySalary { get; set; }

        public double MonthlyExpenses { get; set; }

        public Account Account { get; set; }
    }
}
