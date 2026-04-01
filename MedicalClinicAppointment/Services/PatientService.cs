using MedicalClinicAppointment.Models;
using MedicalClinicAppointment.Services;

// Services/PatientService.cs

namespace MedicalClinicAppointment.Services
{
    public class PatientService : IPatientService
    {
        private readonly List<Patient> _patients = new();
        private int _nextId = 1;

        public Task AddPatientAsync(Patient patient)
        {
            patient.Id = _nextId++;
            _patients.Add(patient);

            return Task.CompletedTask;
        }

        public Task<List<Patient>> GetAllPatientsAsync()
        {
            return Task.FromResult(_patients.ToList());
        }
    }
}
