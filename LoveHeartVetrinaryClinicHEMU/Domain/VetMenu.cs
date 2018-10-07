using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeartVetrinaryClinicHEMU.Domain
{
    class VetMenu
    {
        SystemPatientsDataBase Database = new SystemPatientsDataBase();
        private List<Patient> Patients = new List<Patient>();
        ReceptionistMenu Reception = new ReceptionistMenu();
        public VetMenu()
        {
            Patients = Database.GetPatients();
        }

        public SystemPatientsDataBase GetDatabase()
        {
            return Database;
        }
        /*As a veterinarian I want to be able to list today's appointments so that I can get an overview of today's work
        USV02
        As a veterinarian I want to be able to view an appointment so I can see details related to the visit
        USV03
        As a veterinarian I want to be able to add an entry to a patients journal so that I may record the conclusion of the visit*/
        public void Menu()
        {
            bool LoopIsFinished = false;
            while (LoopIsFinished == false) {
                Database = Reception.GetDatabase(); // since we add stuff and remove stuff as System Admin, we need to Update The Database 
                Patients = Database.GetPatients();// Everything should be fine now.
                Console.WriteLine("== Vet Menu ==");
            Console.WriteLine("\n1. List Appointments / Details\n2. Patient Journals \n3. Log Out");
            Console.Write("\nSelect Action:");
            string choise = Console.ReadLine();
            switch (choise)
            {
                case "1": // cw all Appointments // Choise to see details
                        Database.ListAppointments();
                    break;
                case "2": // cw Patients // choise to see Journals
                        Database.ListPatientsJournals();
                        JournalEntry();
                    break;
                case "3": // when the loop breaks, since it was called from LoginMenu, the app continues in LoginMenu 
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

        private void JournalEntry()
        {
            Console.WriteLine("Select Patient:");
            int choise = Convert.ToInt32(Console.ReadLine());
            Patients[choise - 1].SetJournalEntry();
        }
    }
    }
