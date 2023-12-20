using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicRegistrationandManagementSystem.Models
{
	public class Appointment
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int AppID { get; set; }

		public DateTime AppDate { get; set; }
		public string Status { get; set; }


		[ForeignKey("Specialization")]
        public int SpecID { get; set; }
        [ForeignKey("patient")]
        public int PatientID { get; set; }

        public Patient patient { get; set; }
		public Specialization Specialization { get; set; }

	}
}

