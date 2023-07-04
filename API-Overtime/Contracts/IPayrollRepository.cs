using API_Overtime.Models;
using API_Overtime.ViewModels.Payrolls;

namespace API_Overtime.Contracts
{
    public interface IPayrollRepository : IGenericRepository<Payroll>
    {
        Payroll CreatePayroll(PayrollCreateVM payrollCreate);
        IEnumerable<PayrollPrintVM> GetAllDetailPayrolls();
        IEnumerable<PayrollPrintVM> GetAllDetailPayrollsByEmployeeID(Guid id);
    }
}
