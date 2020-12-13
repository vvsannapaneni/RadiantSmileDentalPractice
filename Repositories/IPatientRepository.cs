using DentalPractice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalPractice.Repositories
{
    public interface IPatientRepository
    {
        IEnumerable<Patients> GetPatients();

        Patients GetPatients(int patientId);

        int SavePatient(int patientId, Patients patients);

        int DeletePatient(int patientId);
    }
}
