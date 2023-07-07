using API_Overtime.Context;
using API_Overtime.Contracts;
using API_Overtime.Models;
using API_Overtime.Repositories;
using API_Overtime.ViewModels.AccountRoles;

namespace API_Overtime.Repositories
{
    public class AccountRoleRepository : GenericRepository<AccountRole>, IAccountRoleRepository
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IEmployeeRepository _employeeRepository;
        public AccountRoleRepository(PayrollOvertimeContext context,
            IAccountRepository accountRepository,
            IEmployeeRepository employeeRepository) : base(context)
        {
            _accountRepository = accountRepository;
            _employeeRepository = employeeRepository;
        }

        public IEnumerable<MasterAccountRoleVM> GetAllMasterAccountRole()
        {
            var accountRoles = GetAll();
            var roles = _context.Roles.ToList();
            var accounts = _accountRepository.GetAll();
            var employee = _employeeRepository.GetAll();
            var query = from acc in accounts
                        join emp in employee
                        on acc.Employee_id equals emp.Id
                        join accRole in accountRoles
                        on acc.Id equals accRole.Account_id
                        join rl in roles
                        on accRole.Role_id equals rl.Id
                        select new MasterAccountRoleVM
                        {
                            Id = accRole.Id,
                            FirstName = emp.FirstName,
                            LastName = emp.LastName,
                            Email = emp.Email,
                            Name = rl.Name,
                            employee_id = emp.Id

                        };

            return query;
        }
    }
}
