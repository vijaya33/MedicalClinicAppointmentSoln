using MedicalClinicAppointment.Models;

namespace MedicalClinicAppointment.Services
{
    public interface IAppointmentService
    {
        Task AddAppointmentAsync(Appointment appointment);
        Task<List<Appointment>> GetAllAppointmentsAsync();
        Task<bool> HasDoctorConflictAsync(int doctorId, DateTime appointmentDate, string appointmentTime);
    }
}