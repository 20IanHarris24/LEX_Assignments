using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelReg
{
    internal class Employee
    {

        public string firstName;
        public string surName;
        public int salary;




       public Employee(string firstName, string surName, int salary)
        {
            this.firstName = firstName;
            this.surName = surName;
            this.salary = salary;

            DisplayEmployeeDetails(firstName, surName, salary);


        }

       



        private static void DisplayEmployeeDetails(string firstName, string surName, int salary)
        {
            Console.WriteLine("\nFirstname: " + firstName + "\nSurname: " + surName + "\nSalary: " + salary);
        }


    }
    }













































