using API_Overtime.Context;
using API_Overtime.Contracts;
using API_Overtime.Models;
using API_Overtime.Repositories;

namespace API_Overtime.Repositories
{
    public class EmployeeLevelRepository : GenericRepository<EmployeeLevel>, IEmployeeLevelRepository
    {
        public EmployeeLevelRepository(PayrollOvertimeContext context) : base(context)
        {
        }
    }
}
