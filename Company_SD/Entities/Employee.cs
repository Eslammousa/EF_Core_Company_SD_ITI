using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_SD.Entities
{
    public class Employee
    {
        public int SSN { get; set; }
        public string ? FName { get; set; }

        public string ?LName { get; set; }

        public int ? Gender { get; set; }

        public DateTime ? DBDate { get; set; }


        // RelationShip 1 : M Dept and Emp and FK is DNo
        public Department ? Departments { get; set; }
        public int  DNo { get; set; } // As FK form table Dept



        // RelationShip 1: 1 between Dept and Emp and is Fk SSN 
        public Department OtherDepartments { get; set; }
        
        public ICollection<Project> Projects { get; set; } = new List<Project>();  
        public ICollection<Work> Works { get; set; } = new List<Work>();

        public ICollection<Dependent>Dependents { get; set; } = new List<Dependent>();


        public int ? SuperId { get; set; } 
        public Employee Employees { get; set; }
        public ICollection<Employee>SuperVisor {  get; set; } = new List<Employee>();


        
    }
}
