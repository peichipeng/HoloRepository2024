using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoloRepository
{
    public class CaseData
    {
        public int DonorId { get; set; }
        public DateTime DOD { get; set; }
        public int Age { get; set; }
        public string causeOfDeath { get; set; }
        public string organs { get; set; }
    }
}
