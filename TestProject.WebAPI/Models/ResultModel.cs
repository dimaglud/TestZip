using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestProject.WebAPI.Models
{
    public class ResultModel
    {
        public bool IsSuccess { get; set; }

        public ErrorCodes ErrorCode { get; set; }

        public string ErrorMessage { get; set; }

    }
}
