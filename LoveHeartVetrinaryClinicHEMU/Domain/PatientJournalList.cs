using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeartVetrinaryClinicHEMU.Domain
{
    class PatientJournalList
    {
        private List<PatientJournal> JournalList = new List<PatientJournal>();
        public PatientJournalList() // Constructor
        {
            JournalList = new List<PatientJournal>{
                new PatientJournal(DateTime.Now, "No Entry"),
                };

        }

        public List<PatientJournal> GetJournalList() // Call this to Export UserList
        {
            return JournalList;
        }
    }
}
