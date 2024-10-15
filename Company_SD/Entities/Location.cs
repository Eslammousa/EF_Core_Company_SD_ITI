using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_SD.Entities
{
    public class Location
    {
        public int DNum { get; set; } // FK form Table Department

        public string ? Loc { get; set; }

        // RelationSip 1 : M between Dept and Loc
        public Department  ? Departments { get; set; }

      

    }

}