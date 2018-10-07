using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeartVetrinaryClinicHEMU.Domain
{
    class PatientJournal
    {
        DateTime VisitDate { get; }
        string Note { get; set; }

        public PatientJournal(DateTime visitDate, string note)
        {
            VisitDate = visitDate;
            Note = note;
        }

        public void SetJournalEntry()
        {
            Note = Console.ReadLine();
        }
    }
}
