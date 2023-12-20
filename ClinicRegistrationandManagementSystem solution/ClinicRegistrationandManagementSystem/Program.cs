using ClinicRegistrationandManagementSystem.Models;
using ClinicRegistrationandManagementSystem.MyDbcontext;

namespace ClinicRegistrationandManagementSystem;
class Program
{
    static void Main(string[] args)
    {
        using ApplictionDbContext context = new ApplictionDbContext();

        //Patient
        Console.Write("Enter patient name: ");
        string patientName = Console.ReadLine();
        Console.Write("Enter contact details: ");
        long PhoneNo = long.Parse(Console.ReadLine());
        Console.Write("Enter Patient Age: ");
        int Age = int.Parse(Console.ReadLine());

        var patient = new Patient { patientName = patientName, PhoneNo = PhoneNo, Age =Age };
        context.Patients.Add(patient);
        context.SaveChanges();

        // Specialization 
        Console.WriteLine("Available Specializations:");
        var specializations = context.Specializations.ToList();
        foreach (var specialization in specializations)
        {
            Console.WriteLine($"{specialization.SpecID}. {specialization.Name}");
        }

        Console.Write("Select a specialization (enter ID): ");
        int specializationID = int.Parse(Console.ReadLine());

        //Appointment
        Console.Write("Enter appointment date (MM/dd/yyyy): ");
        DateTime appointmentDate = DateTime.Parse(Console.ReadLine());

        var appointment = new Appointment
        {
            PatientID = patient.patientID,
            SpecID = specializationID,
            AppDate = appointmentDate,
            Status = "Waiting"
        };

        context.Appointments.Add(appointment);
        context.SaveChanges();

        Console.WriteLine("Appointment booked successfully!");
    }
}

