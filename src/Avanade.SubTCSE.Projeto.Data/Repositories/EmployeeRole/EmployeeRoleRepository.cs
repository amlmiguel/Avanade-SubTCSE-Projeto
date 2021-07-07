using Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Interfaces.Repository;
using Avanade.SubTCSE.Projeto.Infra.Data.Repositories.Base;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Infra.Data.Repositories.EmployeeRole
{
    public class EmployeeRoleRepository : BaseRepository<Domain.Aggregates.EmployeeRole.Entities.EmployeeRole, string>, IEmployeeRoleRepository
    {
        public override Task<Domain.Aggregates.EmployeeRole.Entities.EmployeeRole> Add(Domain.Aggregates.EmployeeRole.Entities.EmployeeRole entity)
        {
            //Fazer qualquer coisa
            entity.RoleName += "sa";

            return base.Add(entity);
        }
    }
}
