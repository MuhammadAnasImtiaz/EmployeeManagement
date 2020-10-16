using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.ViewModels
{
    public class CreateEmployeeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Models.Dept? Department { get; set; }
        public Microsoft.AspNetCore.Http.IFormFile Photo { get; set; }
    }
}
