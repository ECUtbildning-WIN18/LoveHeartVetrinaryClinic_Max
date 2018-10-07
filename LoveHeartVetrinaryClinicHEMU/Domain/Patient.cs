using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeartVetrinaryClinicHEMU.Domain
{
    class Patient : Animal // A Patient must be an Animal
    {
        private DateTime AppointmentDate { get; set; }
        private string Status { get; }
        private string Owner { get; }
        PatientJournalList MyJournal { get; } // Collection of all the "Visists"
        PatientJournal PatientJournal = new PatientJournal(DateTime.Now, " ");

        public Patient(string name,string species,DateTime appointmentDate,
                      string status, string owner, PatientJournalList myJournal) : base(name, species)
        {
            AppointmentDate = appointmentDate;
            Status = status;
            Owner = owner;
            MyJournal = myJournal;
        }

        public string GetStatus()
        {
            return Status;
        }

        public DateTime GetAppointment()
        {
            return AppointmentDate;
        }

        public void SetAppointment(){
            Console.WriteLine("Set new Appointment:");
            AppointmentDate = Convert.ToDateTime(Console.ReadLine());
        }
        
        public void SetJournalEntry()
        {
            PatientJournal.SetJournalEntry();
        }
    }
}
