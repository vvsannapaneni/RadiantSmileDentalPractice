using System.Collections.Generic;
using System.Linq;
using DentalPractice.Model;
using DentalPractice.Repositories;
using System.Data.Entity;

namespace WindowsFormsApp1.Repositories
{
    public class StaffRepository : IStaffRepository
    {
        PatientDbcontext PatientDbcontext = new PatientDbcontext();

        public IEnumerable<PracticeStaff> GetStaffList()
        {
            try
            {
                return PatientDbcontext.PracticeStaff.ToList();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public PracticeStaff GetStaff(int staffId)
        {
            try
            {
                return (from list in PatientDbcontext.PracticeStaff where list.StaffId == staffId select list).FirstOrDefault();
            }
            catch (System.Exception)
            {

                throw;
            }

        }

        public int SaveStaff(int patientId, PracticeStaff staffInfo)
        {
            try
            {
                if (patientId > 0)
                {
                    var objStaff = PatientDbcontext.PracticeStaff.Find(patientId);

                    objStaff.StaffName = staffInfo.StaffName;
                    objStaff.Specialization = staffInfo.Specialization;
                    objStaff.Status = staffInfo.Status;
                    objStaff.Specialization = staffInfo.Specialization;
                    objStaff.ApplyLeave = staffInfo.ApplyLeave;
                    objStaff.LeaveFrom = staffInfo.LeaveFrom;
                    objStaff.LeaveTo = staffInfo.LeaveTo;
                    PatientDbcontext.PracticeStaff.Attach(objStaff);
                    PatientDbcontext.Entry(objStaff).State = EntityState.Modified;
                }
                else
                {
                    PatientDbcontext.PracticeStaff.Add(staffInfo);
                }

                return PatientDbcontext.SaveChanges();
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public int DeleteStaff(int staffId)
        {
            try
            {
                if (staffId > 0)
                {
                    var selectedStaff = GetStaff(staffId);
                    PatientDbcontext.PracticeStaff.Attach(selectedStaff);
                    PatientDbcontext.PracticeStaff.Remove(selectedStaff);
                    return PatientDbcontext.SaveChanges();
                }
                return 0;
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public IList<string> GetStatusList()
        {
            throw new System.NotImplementedException();
        }

        public IList<string> GetServicesList()
        {
            throw new System.NotImplementedException();
        }
    }
}
