using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelReg
{
    internal class EmployeePayroll
    {
        private List<EmployeePayroll> _employeePayrolls

        public void AddEmployee(string name, int salary)
        {
            
            _employeePayrolls.Add(new EmployeePayroll(name, salary));

        }
    }
}
