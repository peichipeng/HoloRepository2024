using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoloRepository.ViewCases
{
    public class CaseData
    {
        public int DonorId { get; set; }
        public DateTime DOD { get; set; }
        public int Age { get; set; }
        public string CauseOfDeath { get; set; }
        public string Organs { get; set; }
    }
}
