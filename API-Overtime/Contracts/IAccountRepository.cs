using API_Overtime.Models;
using API_Overtime.ViewModels.Accounts;
using System.Security.Principal;

namespace API_Overtime.Contracts
{
    public interface IAccountRepository : IGenericRepository<Account>
    {
        Task<int> Register(RegisterVM registerVM);
        int ChangePasswordAccount(Guid? employeeId, ChangePasswordVM changePasswordVM);
        Task<bool> Login(LoginVM loginVM);
        int UpdateOTP(Guid? employeeId);
        Task<UserDateVM> GetUserData(string email);
        Task<List<string>>? GetRoles(string email);
    }
}
