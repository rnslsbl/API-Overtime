using API_Overtime.Contracts;
using API_Overtime.Controllers;
using API_Overtime.Models;
using API_Overtime.ViewModels.Roles;
using Microsoft.AspNetCore.Mvc;

namespace API_Overtime.Controllers
{
    [ApiController]
    [Route("API-Payroll/[controller]")]
    public class RoleController : BaseController<Role, RoleVM>
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper<Role, RoleVM> _mapper;

        public RoleController(IRoleRepository roleRepository, IMapper<Role, RoleVM> mapper) : base (roleRepository, mapper)
        {
            _roleRepository = roleRepository;
            _mapper = mapper;
        }
    }
}
