
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_SD.Entities
{
    public class Work
    {
        public int SSN { get; set; } // as FK From table Emp
        public int PNumber { get; set; } // as FK From table Project
        public int ? Hours { get; set; }
    }
}
