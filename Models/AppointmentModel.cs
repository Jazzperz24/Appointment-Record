using System.ComponentModel.DataAnnotations;

namespace Appointment_Record_Management_System.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Client name is required.")]
        [StringLength(100, ErrorMessage = "Client name cannot exceed 100 characters.")]
        public string ClientName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Service is required.")]
        [StringLength(100, ErrorMessage = "Service cannot exceed 100 characters.")]
        public string Service { get; set; } = string.Empty;

        [Required(ErrorMessage = "Date is required.")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Time is required.")]
        public TimeSpan Time { get; set; }

        [Required(ErrorMessage = "Status is required.")]
        public AppointmentStatus Status { get; set; }
    }

    public enum AppointmentStatus
    {
        Pending,
        Confirmed,
        Cancelled
    }
}