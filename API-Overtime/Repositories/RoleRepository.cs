using API_Overtime.Context;
using API_Overtime.Contracts;
using API_Overtime.Models;

namespace API_Overtime.Repositories
{
    public class RoleRepository : GenericRepository<Role>, IRoleRepository
    {
        public RoleRepository(PayrollOvertimeContext context) : base(context)
        {
        }
    }
}
