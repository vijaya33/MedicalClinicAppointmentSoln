
// Services/IPatientService.cs
using MedicalClinicAppointment.Models;

namespace MedicalClinicAppointment.Services
{
    public interface IPatientService
    {
        Task AddPatientAsync(Patient patient);
        Task<List<Patient>> GetAllPatientsAsync();
    }
}