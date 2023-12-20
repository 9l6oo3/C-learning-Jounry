using System;
using ClinicRegistrationandManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicRegistrationandManagementSystem.MyDbcontext
{
	public class ApplictionDbContext : DbContext 
	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = localhost; Initial Catalog = ClinicRegistrationandManagementSystem; User ID = SA; Password = Sss12345; ");
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

    }
}

