using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelReg
{
    internal class Employee
    {

        public string firstname = "";
        public string surname = "";
        public int salary;


        
        
        public Employee(string firstname, string surname, int salary)
        {
            this.firstname = firstname;
            this.surname = surname;
            this.salary = salary;


            DisplayEmployeeDetails(firstname, surname, salary );


        } 
       
              
        
        
        
       
        private void DisplayEmployeeDetails(string firstname, string surname, int salary)
        {
            Console.WriteLine("\nname: " + firstname + "\nSurname: " + surname + "\nSalary: " + salary);
        }


    }
    }













































}
}
