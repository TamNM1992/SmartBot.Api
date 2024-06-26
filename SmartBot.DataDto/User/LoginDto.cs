using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBot.DataDto.User
{
    public class LoginDto
    {
        public string Token { get; set; }
        public int Status {  get; set; }
        public int IdUser { get; set; }
    }

    public class UserLoginDto
    {
        public int Id { get; set; }

        public string UserName { get; set; } = null!;

        public string Password { get; set; } = null!;

        public byte Status { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime? DateUpdate { get; set; }

        public string? License { get; set; }

        public DateTime? ExpiryDate { get; set; }
    }
    public class ChangePasswordDto
    {
        public string Token { get; set; } = string.Empty;
        public string CurrentPassword { get; set; } = null!;
        public string NewPassword { get; set; } = null!;
        public string ConfirmPassword { get; set; } = null!;

    }
}
