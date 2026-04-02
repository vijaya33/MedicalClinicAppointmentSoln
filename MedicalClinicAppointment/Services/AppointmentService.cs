using MedicalClinicAppointment.Models;

namespace MedicalClinicAppointment.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly List<Appointment> _appointments = new();
        private int _nextId = 1;

        public Task AddAppointmentAsync(Appointment appointment)
        {
            appointment.Id = _nextId++;
            _appointments.Add(appointment);
            return Task.CompletedTask;
        }

        public Task<List<Appointment>> GetAllAppointmentsAsync()
        {
            return Task.FromResult(_appointments.ToList());
        }

        public Task<bool> HasDoctorConflictAsync(int doctorId, DateTime appointmentDate, string appointmentTime)
        {
            var normalizedTime = NormalizeTime(appointmentTime);

            var hasConflict = _appointments.Any(a =>
                a.DoctorId == doctorId &&
                a.AppointmentDate.Date == appointmentDate.Date &&
                NormalizeTime(a.AppointmentTime) == normalizedTime);

            return Task.FromResult(hasConflict);
        }

        private static string NormalizeTime(string? time)
        {
            return (time ?? string.Empty).Trim().ToUpperInvariant();
        }
    }
}