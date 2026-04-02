using MedicalClinicAppointment.Models;

namespace MedicalClinicAppointment.Services
{
    public class DashboardService : IDashboardService
    {
        private readonly IPatientService _patientService;
        private readonly IDoctorService _doctorService;
        private readonly IAppointmentService _appointmentService;
        private readonly IBillService _billService;

        public DashboardService(
            IPatientService patientService,
            IDoctorService doctorService,
            IAppointmentService appointmentService,
            IBillService billService)
        {
            _patientService = patientService;
            _doctorService = doctorService;
            _appointmentService = appointmentService;
            _billService = billService;
        }

        public async Task<DashboardSummary> GetDashboardSummaryAsync()
        {
            var patients = await _patientService.GetAllPatientsAsync();
            var doctors = await _doctorService.GetAllDoctorsAsync();
            var appointments = await _appointmentService.GetAllAppointmentsAsync();
            var bills = await _billService.GetAllBillsAsync();

            var today = DateTime.Today;

            return new DashboardSummary
            {
                TotalPatients = patients.Count,
                TotalDoctors = doctors.Count,
                TotalAppointments = appointments.Count,
                TotalBills = bills.Count,
                PendingPaymentsCount = bills.Count(b => b.PaymentStatus == "Pending" || b.PaymentStatus == "Partially Paid"),
                TotalBilledAmount = bills.Sum(b => b.ConsultationFee),
                TotalCollectedAmount = bills
                    .Where(b => b.PaymentStatus == "Paid")
                    .Sum(b => b.PatientPayableAmount),
                TotalOutstandingAmount = bills
                    .Where(b => b.PaymentStatus == "Pending" || b.PaymentStatus == "Partially Paid")
                    .Sum(b => b.PatientPayableAmount),
                TodayAppointmentsCount = appointments.Count(a => a.AppointmentDate.Date == today)
            };
        }

        public async Task<List<Appointment>> GetTodayAppointmentsAsync()
        {
            var appointments = await _appointmentService.GetAllAppointmentsAsync();
            return appointments
                .Where(a => a.AppointmentDate.Date == DateTime.Today)
                .OrderBy(a => a.AppointmentTime)
                .ToList();
        }
    }
}