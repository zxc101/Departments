using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Departments
{
    class Department
    {
        // Только зачем Employee и Department, я так и не понял
        public string department { get; }
        public Department(string _department)
        {
            department = _department;
        }
    }
}
