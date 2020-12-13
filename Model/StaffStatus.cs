using System.ComponentModel.DataAnnotations;
namespace DentalPractice.Model
{
   public class StaffStatus
    {
        [Key]
        public int StatusId { get; set; }
        public string StatusDescription { get; set; }
    }
}
