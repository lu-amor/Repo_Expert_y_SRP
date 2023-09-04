using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Pacientes StevenJohnson = new Pacientes("Steven Jhonson", "54316734", 37, "5555-555-555");
            Médicos Armand = new Médicos("Armand", "Fisiólogo");
            string appointmentResult = AppointmentService.CreateAppointment(StevenJohnson, DateTime.Now, "Wall Street", Armand);
            Console.WriteLine(appointmentResult);

            Pacientes RalfManson = new Pacientes("Ralph Manson", "984563217", 45, "095674464");
            Médicos Peralta = new Médicos("Peralta", "Médico general");
            string appointmentResult2 = AppointmentService.CreateAppointment(RalfManson, DateTime.Now, "Queen Street", Peralta);
            Console.WriteLine(appointmentResult2);
        }
    }
}
//se debería pedir solo nombre, nombre del médico, hora y lugar