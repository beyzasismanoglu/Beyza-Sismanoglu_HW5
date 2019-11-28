using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Library_Student.Data
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
