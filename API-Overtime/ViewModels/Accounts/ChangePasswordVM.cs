using API_Overtime.Utilities;
using System.ComponentModel.DataAnnotations;

namespace API_Overtime.ViewModels.Accounts
{
    public class ChangePasswordVM
    {
        [EmailAddress]
        [Validation(nameof(Email))]
        public string Email { get; set; }

        public int OTP { get; set; }

        [PasswordValidation(ErrorMessage = "Minimal 6 character, 1 uppercase, 1 lower case, 1 Symbol, 1 number")]
        public string NewPassword { get; set; }

        [Compare("NewPassword")]
        public string ConfirmPassword { get; set; }
    }
}
