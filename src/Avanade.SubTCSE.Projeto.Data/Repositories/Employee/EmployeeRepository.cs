using Avanade.SubTCSE.Projeto.Domain.Aggregates.Employee.Interface.Repositories;
using Avanade.SubTCSE.Projeto.Infra.Data.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Infra.Data.Repositories.Employee
{
    public class EmployeeRepository : BaseRepository<Domain.Aggregates.Employee.Entities.Employee, string>, IEmployeeRepository
    {
        
    }
}
