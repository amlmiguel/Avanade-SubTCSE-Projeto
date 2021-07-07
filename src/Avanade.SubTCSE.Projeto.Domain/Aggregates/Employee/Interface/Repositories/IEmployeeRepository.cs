using Avanade.SubTCSE.Projeto.Domain.Base.Repository;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.Employee.Interface.Repositories
{
    public interface IEmployeeRepository : IBaseRepository<Entities.Employee, string>
    {
    }
}
