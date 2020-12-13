using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalPractice.Model
{
   public class Patients
    {
        [Key]
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string Address { get; set; }
        public DateTime LastVisitedDate { get;  set;}
        public bool IsNhs { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Email { get; set; }
        public string MedicalHistory { get; set; }
        public string GpName { get; set; }
        public string GpAddress { get; set; }

    }
}
