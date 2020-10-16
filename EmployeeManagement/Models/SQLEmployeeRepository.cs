using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class SQLEmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _appDbContext;

        public SQLEmployeeRepository(AppDbContext _appDbContext)
        {
            this._appDbContext = _appDbContext;
        }

        public Employee Add(Employee employee)
        {
            _appDbContext.Employees.Add(employee);
            _appDbContext.SaveChanges();
            return employee;
        }

        public Employee Delete(int id)
        {
            Employee employee = _appDbContext.Employees.Find(id);

            if (employee != null)
            {
                _appDbContext.Employees.Remove(employee);
                _appDbContext.SaveChanges();
            }
            return employee;
        }

        public Employee GetEmployee(int id)
        {
            return _appDbContext.Employees.Find(id);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _appDbContext.Employees.ToList();
        }

        public Employee Update(Employee employeeChanges)
        {
            Employee employee = _appDbContext.Employees.Find(employeeChanges.Id);
            employee.Name = employeeChanges.Name;
            employee.Email = employeeChanges.Email;
            employee.Department = employeeChanges.Department;
            _appDbContext.SaveChanges();
            return employee;

        }
    }
}
