using System.ComponentModel.DataAnnotations;

namespace MedicalClinicAppointment.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Patient is required.")]
        public int PatientId { get; set; }

        [Required(ErrorMessage = "Doctor is required.")]
        public int DoctorId { get; set; }

        [Required(ErrorMessage = "Appointment date is required.")]
        [DataType(DataType.Date)]
        public DateTime AppointmentDate { get; set; } = DateTime.Today;

        [Required(ErrorMessage = "Appointment time is required.")]
        public string AppointmentTime { get; set; } = string.Empty;

        [Required(ErrorMessage = "Reason for visit is required.")]
        [StringLength(300)]
        public string ReasonForVisit { get; set; } = string.Empty;

        public string Status { get; set; } = "Scheduled";
    }
}
