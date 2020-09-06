using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestProject.WebAPI.Models
{
    public class AccountModel
    {
        public Guid? Id { get; set; }

        public Guid UserId { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
