using System.ComponentModel.DataAnnotations;

namespace MedicalClinicAppointment.Models
{
    public class Doctor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [StringLength(100)]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(100)]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Specialization is required.")]
        [StringLength(100)]
        public string Specialization { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Enter a valid email address.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Phone number is required.")]
        [Phone(ErrorMessage = "Enter a valid phone number.")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Range(0, 10000, ErrorMessage = "Consultation fee must be between 0 and 10000.")]
        public decimal ConsultationFee { get; set; }

        [Required(ErrorMessage = "Working hours are required.")]
        [StringLength(100)]
        public string WorkingHours { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}
