using DentalPractice.Repositories;
using DentalPractice.View;
using System;
using System.Linq;

namespace DentalPractice.Presenter
{
    public class StaffPresenter
    {

        private readonly IStaffView _view;
        private readonly IStaffRepository _repository;

        public StaffPresenter(IStaffView view, IStaffRepository repository)
        {
            _view = view;
            view.StaffPresenter = this;
            _repository = repository;
            UpdateListView();
        }

        public void UpdateListView()
        {
            var staff = _repository.GetStaffList();
            _view.StaffId = _view.StaffId >= 0 ? _view.StaffId : 0;
            _view.StaffList = staff.ToList();
        }

        public void Edit(int Id)
        {
            Model.PracticeStaff staffInfo = _repository.GetStaff(Id);

            _view.StaffName = staffInfo.StaffName;
            _view.Specialization = staffInfo.Specialization;
            _view.Status = staffInfo.Status;
            _view.Specialization = staffInfo.Specialization;
            _view.ApplyLeave = staffInfo.ApplyLeave;
            _view.LeaveFrom = staffInfo.LeaveFrom;
            _view.LeaveTo = staffInfo.LeaveTo;

        }

        public int Save()
        {
            Model.PracticeStaff staff = new Model.PracticeStaff
            {
                StaffId = _view.StaffId,
                StaffName = _view.StaffName,
                Specialization = _view.Specialization,
                LeaveFrom = Convert.ToDateTime(_view.LeaveFrom),
                LeaveTo = Convert.ToDateTime(_view.LeaveTo),
                ApplyLeave = _view.ApplyLeave
            };
            int isDataSaved = _repository.SaveStaff(_view.StaffId, staff);
            UpdateListView();
            return isDataSaved;
        }

        public int Delete(int staffId)
        {
            int isDeleted = _repository.DeleteStaff(staffId);
            UpdateListView();
            return isDeleted;
        }
    }
}
