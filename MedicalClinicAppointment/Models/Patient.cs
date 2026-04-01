// Models/Patient.cs
using System.ComponentModel.DataAnnotations;

namespace MedicalClinicAppointment.Models
{
    public class Patient
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [Phone]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; } = DateTime.Today.AddYears(-18);

        [Required]
        [StringLength(200)]
        public string Address { get; set; } = string.Empty;

        [StringLength(100)]
        public string InsuranceProvider { get; set; } = string.Empty;

        [StringLength(100)]
        public string PolicyNumber { get; set; } = string.Empty;

        [StringLength(100)]
        public string EmergencyContactName { get; set; } = string.Empty;

        [Phone]
        public string EmergencyContactPhone { get; set; } = string.Empty;
    }
}