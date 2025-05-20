using FinalProject.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Entities
{
    public class Room
    {
        [Required]
        public string RoomNo { get; set; } = string.Empty;

        public bool IsAvailable { get; set; } = true;

        [Range(0, double.MaxValue, ErrorMessage = "Price must be a positive value.")]
        public decimal Price { get; set; }

        [Required]
        [EnumDataType(typeof(BedType))]
        public BedType BedType { get; set; }
    }
    
}
