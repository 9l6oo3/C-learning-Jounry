using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicRegistrationandManagementSystem.Models
{
	public class Specialization
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SpecID { get; set; }
		public string Name { get; set; }
		public string Discribtion { get; set; }

        public ICollection<Appointment> Appointments { get; set; }

    }
}

