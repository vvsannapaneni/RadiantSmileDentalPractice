using DentalPractice.Model;
using DentalPractice.Presenter;
using System;
using System.Collections.Generic;

namespace DentalPractice.View
{
    public interface IStaffView
    {

        IList<PracticeStaff> StaffList { get; set; }
        int StaffId { get; set; }
        string StaffName { get; set; }
        int Specialization { get; set; }
        int Status { get; set; }
        bool ApplyLeave { get; set; }
        DateTime? LeaveFrom { get; set; }
        DateTime? LeaveTo { get; set; }
        string SpecializationDesc { get; set; }
        string StatusDescription { get; set; }
        List<string> SevicesList { get; set; }
        List<string> StatusList { set; get; }
        StaffPresenter StaffPresenter { get; set; }

    }
}
