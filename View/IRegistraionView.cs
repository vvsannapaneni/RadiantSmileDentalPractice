using DentalPractice.Model;
using DentalPractice.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalPractice.View
{
   public interface IRegistraionView
    {

        IList<Patients> PatientList { get; set; }

        int PatientId { get; set; }

        string PatientName { get; set; }

        string Address { get; set; }

        DateTime? DateOfBirth { get; set; }

        bool IsNhs { get; set; }

        string MedicalHistory { get; set; }

        string Email { get; set; }

        DateTime LastVisitedDate { get; set; }

         string GpName { get; set; }
         string GpAddress { get; set; }

        PatientPresenter Presenter { get; set; }

    }
}
