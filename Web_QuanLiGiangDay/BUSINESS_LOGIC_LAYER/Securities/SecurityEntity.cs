﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC.CONTROLLERS.Securities
{
    public class SecurityEntity
    {        
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public bool IsAdmin { get; set; }
        public string Email { get; set; }
        public bool LoginSuccess { get; set; }
    }
}
