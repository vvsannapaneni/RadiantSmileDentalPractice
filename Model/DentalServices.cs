using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DentalPractice.Model
{
   public class DentalServices
    {
        [Key]
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public int Period { set; get; }
        public double Fee { get; set; }
        public double NhsFee { get; set; }
        public double PrivateFee { get; set; }
    }
}
