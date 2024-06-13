using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Dto.LoginRegisterDtos
{
    public class LoginRegisterViewModel
    {
        public ResultLoginDto LoginModel { get; set; }
        public CreateRegisterDto RegisterModel { get; set; }
        public ProfileCreateDto ProfileCreateDto { get; set; }
    }
}
