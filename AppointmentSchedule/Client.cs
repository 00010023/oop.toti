using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentSchedule
{
    class Client
    {
        public Calendar Calendar
        {
            get => default;
            set
            {
            }
        }

        public Doctor Doctor
        {
            get => default;
            set
            {
            }
        }

        public Patient Patient
        {
            get => default;
            set
            {
            }
        }

        public static void Launch()
        {
            // Initializing Calendar
            var calendar = new Calendar();

            // Creating Actors
            var patient1 = new Patient("Akhmad");
            var doctor1 = new Doctor("Dr.Behruz", "Cardiology");
            calendar.AddAppointment("About cardios", doctor1, patient1);

            var patient2 = new Patient("Rizal");
            var doctor2 = new Doctor("Dr.Akmal", "Surgery");
            calendar.AddAppointment("About surgery", doctor2, patient2);

            calendar.PrintAppointments();

        }
    }
}
