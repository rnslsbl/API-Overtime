using API_Overtime.Models;
using API_Overtime.ViewModels.AccountRoles;
using System.Security.Principal;

namespace API_Overtime.Contracts
{
    public interface IAccountRoleRepository : IGenericRepository<AccountRole>
    {
        IEnumerable<MasterAccountRoleVM> GetAllMasterAccountRole();
    }
}
