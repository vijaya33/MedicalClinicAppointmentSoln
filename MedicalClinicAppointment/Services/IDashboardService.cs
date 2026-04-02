using MedicalClinicAppointment.Models;

namespace MedicalClinicAppointment.Services
{
    public interface IDashboardService
    {
        Task<DashboardSummary> GetDashboardSummaryAsync();
        Task<List<Appointment>> GetTodayAppointmentsAsync();
    }
}