using Avanade.SubTCSE.Projeto.Domain.Aggregates.Employee.Interface.Services;
using System.Threading.Tasks;
using System;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.Employee.Services
{
    public class EmployeeService : IEmployeeService
    {
        public async Task<Entities.Employee> AddEmployee(Entities.Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
