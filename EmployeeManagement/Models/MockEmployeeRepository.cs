using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        List<Employee> _getEmployee;
        public MockEmployeeRepository()
        {
            _getEmployee = new List<Employee>()
            {
                new Employee{Id=1,Name="M.Anas Imtiaz",Email="anasimtiaz@gmail.com",Department=Dept.HR},
                new Employee{Id=2,Name="M.Anus Baig",Email="anasbaig@gmail.com",Department=Dept.IT},
                new Employee{Id=3,Name="Ammad Majid",Email="ammadmajid@gmail.com",Department=Dept.IT}
            };
        }

        public Employee Add(Employee employee)
        {
            employee.Id = _getEmployee.Max(e => e.Id) + 1;
            _getEmployee.Add(employee);
            return employee;
        }

        public Employee Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(int id)
        {
            return _getEmployee.FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _getEmployee;
        }

        public Employee Update(Employee employeeChanges)
        {
            throw new NotImplementedException();
        }
    }
}
