using MedicalClinicAppointment.Models;

namespace MedicalClinicAppointment.Services
{
    public interface IAppointmentService
    {
        Task AddAppointmentAsync(Appointment appointment);
        Task<List<Appointment>> GetAllAppointmentsAsync();


    }
}