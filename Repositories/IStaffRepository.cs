using DentalPractice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalPractice.Repositories
{
    public interface IStaffRepository
    {
        IEnumerable<PracticeStaff> GetStaffList();
        IList<string> GetStatusList();
        IList<string> GetServicesList();

        PracticeStaff GetStaff(int staffId);

        int SaveStaff(int staffId, PracticeStaff practiceStaff);

        int DeleteStaff(int staffId);
    }
}
