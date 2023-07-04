using API_Overtime.Models;
using API_Overtime.ViewModels.Employees;

namespace API_Overtime.Contracts
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        bool CheckValidation(string value);
        Employee FindEmployeeByEmail(string email);
        int CreateWithValidate(Employee emloyee);
        IEnumerable<MasterEmployeeVM> GetAllMasterEmployee();
    }
}
