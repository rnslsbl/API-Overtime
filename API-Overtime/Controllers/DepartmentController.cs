using API_Overtime.Contracts;
using API_Overtime.Controllers;
using API_Overtime.Models;
using API_Overtime.ViewModels.Departments;
using Microsoft.AspNetCore.Mvc;

namespace API_Overtime.Controllers
{
    [ApiController]
    [Route("API-Payroll/[controller]")]
    public class DepartmentController : BaseController<Department, DepartmentVM>
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IMapper<Department, DepartmentVM> _mapper;

        public DepartmentController(IDepartmentRepository departmentRepository, IMapper<Department, DepartmentVM> mapper) : base(departmentRepository, mapper)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
        }
    }
}
