﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserManage.Database.Entities
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }

    }
}
