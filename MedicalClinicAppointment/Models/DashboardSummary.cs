namespace MedicalClinicAppointment.Models
{
    public class DashboardSummary
    {
        public int TotalPatients { get; set; }
        public int TotalDoctors { get; set; }
        public int TotalAppointments { get; set; }
        public int TotalBills { get; set; }
        public int PendingPaymentsCount { get; set; }
        public decimal TotalBilledAmount { get; set; }
        public decimal TotalCollectedAmount { get; set; }
        public decimal TotalOutstandingAmount { get; set; }
        public int TodayAppointmentsCount { get; set; }
    }
}