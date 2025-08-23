using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_Dev.Models
{
    public class Password
    {
        [Range(minimum:1,int.MaxValue)]
        public int PasswordID { get; set; }

        [MaxLength(50)]
        public string OldPassword { get; set; }

        [MaxLength(50)]
        public string NewPassword { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
