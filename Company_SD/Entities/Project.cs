using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_SD.Entities
{
    public class Project
    {
        public int PNum {  get; set; }

        public string ? PName { get; set; }

        public string ? City {  get; set; }

        public string ? Loc {  get; set; }

        // RelationShip 1 : M between Dept and Project as Fk form table Dept is DNum
        public Department ? Departments { get; set; }
        public int DNum { get; set; }


        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
        public ICollection<Work> Works { get; set; } = new List<Work>();





    }
}
