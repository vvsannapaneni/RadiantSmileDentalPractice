using System.Collections.Generic;
using System.Linq;
using DentalPractice.Model;
using DentalPractice.Repositories;
using System.Data.Entity;

namespace WindowsFormsApp1.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        PatientDbcontext patientDbcontext = new PatientDbcontext();

        public IEnumerable<Patients> GetPatients()
        {
            try
            {
                return patientDbcontext.Patients.ToList();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public Patients GetPatients(int patientId)
        {
            try
            {
                return (from list in patientDbcontext.Patients where list.PatientId == patientId select list).FirstOrDefault();

            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public int SavePatient(int patientId, Patients patientInfo)
        {
            try
            {
                if (patientId > 0)
                {
                    var objPatient = patientDbcontext.Patients.Find(patientId);

                    objPatient.Address = patientInfo.Address;
                    objPatient.PatientName = patientInfo.PatientName;
                    objPatient.DateOfBirth = patientInfo.DateOfBirth;
                    objPatient.IsNhs = patientInfo.IsNhs;
                    objPatient.MedicalHistory = patientInfo.MedicalHistory;
                    objPatient.Email = patientInfo.Email;
                    patientDbcontext.Patients.Attach(objPatient);
                    patientDbcontext.Entry(objPatient).State = EntityState.Modified;
                }
                else
                {
                    patientInfo.LastVisitedDate = System.DateTime.Now;
                    patientDbcontext.Patients.Add(patientInfo);
                }

                return patientDbcontext.SaveChanges();
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public int DeletePatient(int patientId)
        {
            try
            {
                if (patientId > 0)
                {
                    var selectedPatient = GetPatients(patientId);
                    patientDbcontext.Patients.Attach(selectedPatient);
                    patientDbcontext.Patients.Remove(selectedPatient);
                    return patientDbcontext.SaveChanges();
                }
                return 0;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

    }
}
