using API_Overtime.Models;
using API_Overtime.ViewModels.Overtimes;
using System.Data;

namespace API_Overtime.Contracts
{
    public interface IEmployeeOvertimeRepository : IGenericRepository<Overtime>
    {
        /*Overtime CreateRequest(Overtime overtime);
        int ApprovalOvertime(Overtime overtime,Guid id);
        List<OvertimeApprovalVM> ListOvertimeByIdManager(Guid managerId);

		IEnumerable<OvertimeVM> ListOvertimeByIdEmployee(Guid idEmployee);

        IEnumerable<OvertimeRemainingVM> ListRemainingOvertime();
        IEnumerable<OvertimeRemainingVM> ListRemainingOvertimeByGuid(Guid id);
        OvertimeRemainingVM RemainingOvertimeByEmployeeGuid(Guid id);
        ChartManagerVM DataChartByGuid(Guid id);*/
        Overtime CreateRequest(Overtime overtime);
        int ApprovalOvertime(Overtime overtime, Guid id);
        List<OvertimeApprovalVM> ListOvertimeByIdManager(Guid idManager);
        IEnumerable<OvertimeVM> ListOvertimeByIdEmployee(Guid idEmployee);

        IEnumerable<OvertimeRemainingVM> ListRemainingOvertime();
        IEnumerable<OvertimeRemainingVM> ListRemainingOvertimeByGuid(Guid id);
        OvertimeRemainingVM RemainingOvertimeByEmployeeGuid(Guid id);
        ChartManagerVM DataChartByGuid(Guid id);


    }
}
