using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees(int companyId, bool trackChanges);

        Employee GetEmployee(int companyId, int id, bool trackChanges);
    }
}
