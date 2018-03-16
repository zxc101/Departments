using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Departments
{
    class Employee
    {
        private string surname;
        private string _FName;
        private string _LName;
        private string department;

        public string Surname { get => surname; set { surname = value; } }

        public string FName { get => _FName; set { _FName = value; } }

        public string LName { get => _LName; set { _LName = value; } }

        public string Department { get => department; set { department = value; } }
    }
}
