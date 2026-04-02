using System.ComponentModel.DataAnnotations;

namespace MedicalClinicAppointment.Models
{
    public class Bill
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Patient is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Please select a patient.")]
        public int PatientId { get; set; }

        [Required(ErrorMessage = "Doctor is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Please select a doctor.")]
        public int DoctorId { get; set; }

        public int? AppointmentId { get; set; }

        [Required(ErrorMessage = "Invoice number is required.")]
        [StringLength(50)]
        public string InvoiceNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Bill date is required.")]
        [DataType(DataType.Date)]
        public DateTime BillDate { get; set; } = DateTime.Today;

        [Range(0, 100000, ErrorMessage = "Consultation fee must be valid.")]
        public decimal ConsultationFee { get; set; }

        [Range(0, 100000, ErrorMessage = "Insurance coverage must be valid.")]
        public decimal InsuranceCoverage { get; set; }

        [Range(0, 100000, ErrorMessage = "Patient payable amount must be valid.")]
        public decimal PatientPayableAmount { get; set; }

        [Required(ErrorMessage = "Payment method is required.")]
        [StringLength(50)]
        public string PaymentMethod { get; set; } = "Cash";

        [StringLength(300)]
        public string Notes { get; set; } = string.Empty;

        [Required(ErrorMessage = "Payment status is required.")]
        [StringLength(50)]
        public string PaymentStatus { get; set; } = "Pending";
    }
}