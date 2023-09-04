using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        public string MName;
        public static string CreateAppointment(Pacientes pacientes, DateTime date, string appoinmentPlace, Médicos Médicos)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (!IdUtils.IdIsValid(Pacientes.GetId()))
            {
                stringBuilder.Append("Unable to schedule appointment, valid 'id' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, valid 'appoinment place' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(MName.Get()))
            {
                stringBuilder.Append("Unable to schedule appointment, valid 'doctor name' is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment scheduled");
            }

            return stringBuilder.ToString();
        }

    }
}
/*
la información de los pacientes debería almacenarse toda junta
la información de los médicos debería almacenarse toda junta
*/

