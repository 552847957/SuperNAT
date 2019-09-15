﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperNAT.Common.Models
{
    [Table("user")]
    public class User : BaseModel, IModel
    {
        [Key]
        public int id { get; set; }
        public string user_id { get; set; }
        public string user_name { get; set; } = "";
        public string password { get; set; } = "";
        public string wechat { get; set; } = "";
        public string tel { get; set; } = "";
        public bool is_disabled { get; set; } = true;
        public bool is_admin { get; set; } = false;
        [Editable(false)]
        public string is_disabled_str => is_disabled ? "禁用" : "正常";
        [Editable(false)]
        public string token { get; set; }
    }
}
