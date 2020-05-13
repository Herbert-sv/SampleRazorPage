using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleRazor
{
    public class EmployeesDirectory
    {
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Superior { get; set; }
        public long PhoneNumber { get; set; }
        public string EmailAddress { get; set; }



        public List<EmployeesDirectory> EmployeesInformation()
        {
            List<EmployeesDirectory> emp = new List<EmployeesDirectory>();
            EmployeesDirectory emp1 = new EmployeesDirectory()
            {EmpId=1, FirstName = "Henry", LastName = "Smith", Position = "Regional Sales", Superior = "Gerber Wilson", PhoneNumber = 3454780789, EmailAddress = "Henry_@communicationInc.com" };
            EmployeesDirectory emp2 = new EmployeesDirectory()
            { EmpId=2 ,FirstName = "Carlson", LastName = "Jordan", Position = "Regional Manager", Superior = "Scott Raboski", PhoneNumber = 4563456754, EmailAddress = "Carlson_@CommunicationInc.com" };
            EmployeesDirectory emp3 = new EmployeesDirectory()
            { EmpId=3, FirstName = "Raschel", LastName = "Brown", Position = "Regional Consultant", Superior = "David Luke", PhoneNumber = 4566789078, EmailAddress = "Rashel_@comunicationInc.com" };
            EmployeesDirectory emp4 = new EmployeesDirectory()
            { EmpId=4,FirstName = "Mary", LastName = "Sanchez", Position = "Regional Buyer", Superior = "Ann Podolsky", PhoneNumber = 5647895647, EmailAddress = "Mary_@communicationInc.com" };
            EmployeesDirectory emp5 = new EmployeesDirectory()
            { EmpId=5,FirstName = "David", LastName = "Lopez", Position = "Regional Consultant", Superior = "John Bartelli", PhoneNumber = 7654355467, EmailAddress = "David_@communicationInc.com" };

            emp.Add(emp1);
            emp.Add(emp2);
            emp.Add(emp3);
            emp.Add(emp4);
            emp.Add(emp5);
            emp.ToList();
            return emp;
        }
       
    }

    }



