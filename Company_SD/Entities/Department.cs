using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_SD.Entities
{
    public class Department
    {
        public int DNum { get; set; }
        public string ? DName { get; set; }

        // RelationShip 1 : M between Dept and Loc 
        public ICollection<Location> Locations { get; set; }  = new List<Location>();

        // RelationShip 1 : M Dept and Emp and FK is DNo
        public ICollection<Employee> Employees { get; set; } =  new List<Employee>();

        public DateTime ? hireDate { get; set; }


        // RelationShip 1: 1 between Dept and Emp // as Fk from table Emp
        public Employee ? OtherEmployees { get; set; }
        public int  MrgSSN { get; set; } 

        // RelationShip 1 : M between Dept and Project as Fk form table Dept is DNum
        public ICollection<Project>Projects { get; set; } = new List<Project>();


    }
}
