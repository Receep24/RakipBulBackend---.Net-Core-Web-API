﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class PasswordChangeDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
