﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBot.DataDto.Group
{
    public class InsertGroupDto
    {
        public string FbUser {  get; set; }
        public List<GroupDataDto> Groups { get; set; }
    }
}
