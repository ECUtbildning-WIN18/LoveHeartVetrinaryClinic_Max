using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeartVetrinaryClinicHEMU.Domain
{
    class SystemPatientsDataBase
    {
        private PatientList PatientList = new PatientList();
        private List<Patient> Patients;

        public SystemPatientsDataBase()
        {
            Patients = PatientList.GePatients();
        }

        public List<Patient> GetPatients()
        {
            return Patients;
        }

        public void AddPatient()
        {
            string Name = "default";
            string Species = "default";
            DateTime Appointment = new DateTime();
            string Status = "default";
            string Owner = "default";
            Console.Clear();
            Console.Write("Enter Patient Name:");
            Name = Console.ReadLine();
            Console.Write("\nEnter Patient Species:");
            Species = Console.ReadLine();
            Console.Write("Enter Appointment Date:");
            Appointment = Convert.ToDateTime(Console.ReadLine());
            Console.Write("\nEnter Patient Ailment:");
            Status = Console.ReadLine();
            Console.Write("\nEnter Patients Owner:");
            Owner = Console.ReadLine();
            PatientJournalList NewJournal = new PatientJournalList();
            Patient NewSickAnimal = new Patient(Name, Species, Appointment, Status, Owner, NewJournal);
            Patients.Add(NewSickAnimal);
        }

        public void ListPatients()
        {
            int i = 1;
            foreach (Patient patient in Patients)
            {
                Console.WriteLine(i + ". " + patient.GetName() + "\tAnimal: " + patient.GetSpecies() +
                    "\tAppointment: " + patient.GetAppointment() + "\tAilment: " + patient.GetStatus());
                i++;
            }
        }

        public void ListPatientsJournals()
        {
            int i = 1;
            foreach (Patient patient in Patients)
            {
                Console.WriteLine(i + ". " + patient.GetName() + "\tAnimal: " + patient.GetSpecies() +
                    "\tAppointment: " + patient.GetAppointment() + "\tAilment: " + patient.GetStatus());
                i++;
            }
        }

        public void ListAppointments()
        {
            int i = 1;
            foreach (Patient patient in Patients)
            {
                Console.WriteLine(i + ". Appointment Date: "+patient.GetAppointment() +"\tAnimal: " + patient.GetSpecies() +
                    "\tName:" + patient.GetName());
                i++;
            }
        }
    }
}
