using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Entities
{
    public class Department
    {
        [Required]
        public string DeptName { get; set; } = string.Empty;

        [Required]
        public string HODName { get; set; } = string.Empty;

        public List<string> EmpaneledDoctorNames { get; set; } = new List<string>();

        [MaxLength(3, ErrorMessage = "Phone extension must be at most 3 digits.")]
        public int PhoneExtension { get; set; }
    }

}
