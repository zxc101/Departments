using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Departments.Presenters;
using Departments.IViews;

namespace Departments
{
    public partial class AddEditEmployee : Window, AddEditEmployeeIView
    {
        public string Surname {
            get => SurnameTB.Text;
            set { SurnameTB.Text = value; }
        }

        public string FName {
            get => FNameTB.Text;
            set { FNameTB.Text = value; }
        }

        public string LName {
            get => LNameTB.Text;
            set { LNameTB.Text = value; }
        }

        public string Department {
            get {
                    try
                    {
                        return DepartmentCB.SelectedItem.ToString();
                    }
                    catch (NullReferenceException)
                    {
                        return "";
                    }
            }
            set { DepartmentCB.SelectedItem = value; }
        }

        public Window Win
        {
            get => this;
        }
        
        public AddEditEmployee()
        {
            InitializeComponent();

            AddEditEmployeePresenter presenter = new AddEditEmployeePresenter(this);
            DepartmentCB.ItemsSource = presenter.GetDepartments();

            AddEditBTN.Click += (s, e) => presenter.AddEditEmployee();
        }
    }
}
