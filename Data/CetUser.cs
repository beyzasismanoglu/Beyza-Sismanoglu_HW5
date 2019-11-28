using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Library_Student.Data
{
    public class CetUser
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength =2)]
        public string Name { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Surname { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string UserName { get; set; }
        [Required]
        [StringLength(256)]
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        
        public string RoleName { get; set; }
    }
}
