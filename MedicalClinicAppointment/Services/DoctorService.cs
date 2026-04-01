using MedicalClinicAppointment.Models;

namespace MedicalClinicAppointment.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly List<Doctor> _doctors = new();
        private int _nextId = 1;

        public Task AddDoctorAsync(Doctor doctor)
        {
            doctor.Id = _nextId++;
            _doctors.Add(doctor);
            return Task.CompletedTask;
        }

        public Task<List<Doctor>> GetAllDoctorsAsync()
        {
            return Task.FromResult(_doctors.ToList());
        }
    }
}
