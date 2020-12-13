using DentalPractice.Repositories;
using DentalPractice.View;
using System;
using System.Linq;

namespace DentalPractice.Presenter
{
    public class PatientPresenter
    {

        private readonly IRegistraionView _view;
        private readonly IPatientRepository _repository;

        public PatientPresenter(IRegistraionView view, IPatientRepository repository)
        {
            _view = view;
            view.Presenter = this;
            _repository = repository;
            UpdateCustomerListView();
        }

        public void UpdateCustomerListView()
        {
            var Patients = _repository.GetPatients();
            _view.PatientId = _view.PatientId >= 0 ? _view.PatientId : 0;
            _view.PatientList = Patients.ToList();
        }

        public void Edit(int Id)
        {
            Model.Patients patient = _repository.GetPatients(Id);
            _view.PatientName = patient.PatientName;
            _view.DateOfBirth = patient.DateOfBirth;
            _view.IsNhs = patient.IsNhs;
            _view.Address = patient.Address;
            _view.MedicalHistory = patient.MedicalHistory;
           
        }

        public int Save()
        {
            Model.Patients patient = new Model.Patients { PatientId=_view.PatientId ,PatientName = _view.PatientName, Address = _view.Address,
                DateOfBirth = Convert.ToDateTime(_view.DateOfBirth)
            ,IsNhs=_view.IsNhs};
           int isDataSaved = _repository.SavePatient(_view.PatientId, patient);
            UpdateCustomerListView();
            return isDataSaved;
        }

        public int Delete(int patientid)
        {
           int isDeleted=  _repository.DeletePatient(patientid);
            UpdateCustomerListView();
            return isDeleted;
        }
    }
}
