using API_Overtime.Contracts;
using API_Overtime.Models;
using API_Overtime.ViewModels.AccountRoles;
using API_Overtime.ViewModels.Others;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace API_Overtime.Controllers
{
    [ApiController]
    [Route("API-Payroll/[controller]")]
    public class AccountRoleController : BaseController<AccountRole, AccountRoleVM>
    {
        private readonly IAccountRoleRepository _accountRoleRepository;
        private readonly IMapper<AccountRole, AccountRoleVM> _mapper;

        public AccountRoleController(IAccountRoleRepository accountRoleRepository, IMapper<AccountRole, AccountRoleVM> mapper) : base(accountRoleRepository, mapper)
        {
            _accountRoleRepository = accountRoleRepository;
            _mapper = mapper;
        }

        [HttpGet("GetAllMasterAccountRole")]
        public IActionResult GetAllMasterAccountRole()
        {
            var masterAccountRole = _accountRoleRepository.GetAllMasterAccountRole();
            if (!masterAccountRole.Any())
            {
                return NotFound(new ResponseVM<MasterAccountRoleVM>
                {
                    Code = StatusCodes.Status404NotFound,
                    Status = HttpStatusCode.NotFound.ToString(),
                    Message = "Data Account Role Tidak Ditemukan",
                });
            }

            return Ok(new ResponseVM<IEnumerable<MasterAccountRoleVM>>
            {
                Code = StatusCodes.Status200OK,
                Status = HttpStatusCode.OK.ToString(),
                Message = "Data Master Account Role Berhasil Ditampilkan",
                Data = masterAccountRole
            });
        }
    }
}
