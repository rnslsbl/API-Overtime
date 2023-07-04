using API_Overtime.Contracts;
using API_Overtime.Controllers;
using API_Overtime.Models;
using API_Overtime.ViewModels.EmployeeLevels;
using Microsoft.AspNetCore.Mvc;

namespace API_Overtime.Controllers
{
    [ApiController]
    [Route("API-Payroll/[controller]")]
    public class EmployeeLevelController : BaseController<EmployeeLevel, EmployeeLevelVM>
    {

        private readonly IEmployeeLevelRepository _employeeLevelRepository;
        private readonly IMapper<EmployeeLevel, EmployeeLevelVM> _mapper;

        public EmployeeLevelController(IEmployeeLevelRepository employeeLevelRepository, IMapper<EmployeeLevel, EmployeeLevelVM> mapper) : base(employeeLevelRepository, mapper)
        {
            _employeeLevelRepository = employeeLevelRepository;
            _mapper = mapper;
        }
    }
}
