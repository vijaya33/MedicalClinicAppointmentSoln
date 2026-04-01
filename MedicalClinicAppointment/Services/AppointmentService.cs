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
    }
}
