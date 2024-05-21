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




       public Employee(string firstName, string surName, string salary)
        {
            this.firstName = firstName;
            this.surName = surName;
            this.salary = int.Parse(salary);

            DisplayEmployeeDetails(firstName, surName, this.salary);


        }

       



        private static void DisplayEmployeeDetails(string firstName, string surName, int salary)
        {
            string response = $"Firstname {firstName}\nSurname\t{surName}\nSalary\t{salary}\n" ;
            Console.WriteLine(response);
        }


    }
    }













































