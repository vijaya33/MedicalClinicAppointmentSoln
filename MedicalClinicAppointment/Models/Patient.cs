// Models/Patient.cs
using System.ComponentModel.DataAnnotations; 
     

namespace MedicalClinicAppointment.Models
    {
        public class Patient
        {
            public int Id { get; set; }

            [Required(ErrorMessage = "First name is required.")]
            [StringLength(100)]
            public string FirstName { get; set; } = string.Empty;

            [Required(ErrorMessage = "Last name is required.")]
            [StringLength(100)]
            public string LastName { get; set; } = string.Empty;

            [Required(ErrorMessage = "Email is required.")]
            [EmailAddress(ErrorMessage = "Enter a valid email address.")]
            public string Email { get; set; } = string.Empty;

            [Required(ErrorMessage = "Phone number is required.")]
            [Phone(ErrorMessage = "Enter a valid phone number.")]
            public string PhoneNumber { get; set; } = string.Empty;

            [Required(ErrorMessage = "Date of birth is required.")]
            [DataType(DataType.Date)]
            public DateTime DateOfBirth { get; set; } = DateTime.Today.AddYears(-18);

            [Required(ErrorMessage = "Address is required.")]
            [StringLength(200)]
            public string Address { get; set; } = string.Empty;

            [StringLength(100)]
            public string InsuranceProvider { get; set; } = string.Empty;

            [StringLength(100)]
            public string PolicyNumber { get; set; } = string.Empty;

            [StringLength(100)]
            public string EmergencyContactName { get; set; } = string.Empty;

            [Phone(ErrorMessage = "Enter a valid emergency contact phone number.")]
            public string EmergencyContactPhone { get; set; } = string.Empty;
        }
    }

