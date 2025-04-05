using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp1.Models
{
	public class Login
	{

        [Required(ErrorMessage = "Vui lòng nhập tên đăng nhập")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}