using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArchPointPHR.Models
{
    public class Medication
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 4)]
        [Required]
        public string Name { get; set; }

        [StringLength(70, MinimumLength = 15)]
        [Required]
        public string Physician { get; set; }

        [Range(1, 1000)]
        [Display(Name = "Quantity")]
        [DataType(DataType.MultilineText)]
        public int Quantity { get; set; }

        //[RegularExpression(@"^[A-z]+[a-zA-Z0-9""'\s-]*$")]
        //[Required]
        [StringLength(30)]
        public string Dosage { get; set; }

        [StringLength(200, MinimumLength = 5)]
        [Required]
        public string Reason { get; set; }

        [RegularExpression(@"^[A-z]+[a-zA-Z0-9""'\s-]*$")]
        [Required]
        [StringLength(30)]
        public string Type { get; set; }
    }
}
