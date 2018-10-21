using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArchPointPHR.Models
{
    public class Medication
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Physician { get; set; }
        public int Quantity { get; set; }
        public string Dosage { get; set; }
        public string Reason { get; set; }
    }
}
