using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace TestProject.WebAPI.Models
{
    public class UserModel
    {
        public Guid? Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Value must be positive")]
        public double MonthlySalary { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Value must be positive")]
        public double MonthlyExpenses { get; set; }
    }
}
