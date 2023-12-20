using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicRegistrationandManagementSystem.Models
{
	public class Patient
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int patientID { get; set; }
		public string patientName { get; set; }
		public int Age { get; set; }
		public long PhoneNo { get; set; }

		public ICollection<Appointment> Appointments { get; set; }

	}
}

