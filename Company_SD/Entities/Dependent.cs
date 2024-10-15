using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_SD.Entities
{
    public class Dependent
    {
        public int DName {get ; set;}

        public DateTime ? BDate {get ; set;}

        public string ? Gender {get ; set;}


        public Employee ? Employees {get ; set;}
        public int SSN {get ; set;} // as Fk Form table Emp


    }
}
