﻿using System;
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
}
