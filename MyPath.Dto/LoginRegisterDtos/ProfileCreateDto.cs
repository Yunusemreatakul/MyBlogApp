using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPath.Dto.LoginRegisterDtos
{
	public class ProfileCreateDto
	{
		public string FullName { get; set; }
        public DateOnly  DateOfBirth { get; set; }

        public string Email { get; set; }
	}
}
