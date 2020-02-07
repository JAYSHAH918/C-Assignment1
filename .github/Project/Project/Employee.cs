using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Employee
    {
         String Id;
         String Name;
         String DepartmentName;

        public string GetId(String Id)
        {
            this.Id=Id;
            return Id;
        }
        public string GetName(String Name)
        {
            this.Name = Name;
            return Name;
        }
        public string GetDepartmentName(String DepartmentName)
        {
            this.DepartmentName = DepartmentName;
            return DepartmentName;
        }


       /* internal void GetId(string a)
        {
            throw new NotImplementedException();
            
        }*/
    }
    
}
