using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Departments.IViews
{
    interface AddEditEmployeeIView
    {
        string Surname { get; set; }
        string FName { get; set; }
        string LName { get; set; }
        string Department { get; set; }
        Window Win { get; }
    }
}
