
using MedicalClinicAppointment.Models;

namespace MedicalClinicAppointment.Services
{
    public interface IDoctorService
    {
        Task AddDoctorAsync(Doctor doctor);
        Task<List<Doctor>> GetAllDoctorsAsync();

        Task<List<Doctor>> GetActiveDoctorsAsync(); 
    }
}