using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeartVetrinaryClinicHEMU.Domain
{
    class PatientList
    {
        private  List<Patient> PatientsList = new List<Patient>();
        DateTime TestDate = DateTime.Now;
        PatientJournalList NewJournal = new PatientJournalList();
        public PatientList() // Constructor
        {
            PatientsList = new List<Patient>{ // When you create a Object of this class
            new Patient("Coolio","Cat", TestDate,"Feaver", "Mr Green", NewJournal),// You automaticlly get a list of Patients
            new Patient("Rex       ","Dog", TestDate,"Decaying Brain", "The King", NewJournal),
            new Patient("Dogmeat","Dog", TestDate,"Meatshield", "The Lone Wanderer", NewJournal),
            
            };
        }

        public List<Patient> GePatients() // Call this to Export UserList
        {
            return PatientsList;
        }


        public int SelectTarget(int currentTarget)
        {
                Console.WriteLine("Select Target:");
                currentTarget = Convert.ToInt32(Console.ReadLine());
                 return currentTarget;
        }
    }
}
