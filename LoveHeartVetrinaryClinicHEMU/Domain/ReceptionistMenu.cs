using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeartVetrinaryClinicHEMU.Domain
{
    class ReceptionistMenu
    {
        private PatientList PatientList = new PatientList();
        private List<Patient> Patients;
        SystemPatientsDataBase Database = new SystemPatientsDataBase();
        public ReceptionistMenu() 
        {
            Patients = Database.GetPatients();
        }

        public SystemPatientsDataBase GetDatabase()
        {
            return Database;
        }

        public void Menu()
        {
            bool LoopIsFinished = false;
            while (LoopIsFinished == false) {
                Console.WriteLine("== Reception Menu ==");
            Console.WriteLine("\n1. Register new patients\n2. List existing patients\n3. Change Appointment\n4. Log Out");
            Console.Write("\nSelect Action:");
            string choise = Console.ReadLine();
            switch (choise)
            {
                case "1": // Add Patient to the list
                    Database.AddPatient();
                    break;
                case "2": // cw the List
                   Database.ListPatients();
                    break;
                case "3":
                    ChangeAppointment();
                    break;
                case "4": // Go back to Login Screen
                        LoopIsFinished = true;
                    break;
                default:
                    Console.WriteLine("--Unkown Action--"); // Select Better noob! :p
                    break;
            }
            Console.ReadLine();
            Console.Clear();
            }
        }
        
        private void ChangeAppointment()
        {
            Database.ListPatients();
            int TargetIndex = 0;
            TargetIndex = PatientList.SelectTarget(TargetIndex);
            Patients[TargetIndex - 1].SetAppointment(); 
        }
    }
}
