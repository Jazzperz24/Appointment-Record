using Microsoft.EntityFrameworkCore;
using Appointment_Record_Management_System.Models;

namespace Appointment_Record_Management_System.Information
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Appointment> Appointments { get; set; }
    }
}