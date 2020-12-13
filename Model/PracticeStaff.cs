using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DentalPractice.Model
{
    public class PracticeStaff
    {
        [Key]
        public int StaffId { get; set; }
        public string StaffName { get; set; }
        public int Specialization { get; set; }
        public string SpecializationDesc { get; set; }
        public int Status { get; set; }
        public string StatusDescription { get; set; }
        public bool ApplyLeave { get; set; }
        public DateTime? LeaveFrom { get; set; }
        public DateTime? LeaveTo { get; set; }
        public List<string> SevicesList { get; set; }
        public List<string> StatusList { set; get; }


    }
}
