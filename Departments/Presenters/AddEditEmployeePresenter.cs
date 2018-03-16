using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Departments.IViews;

namespace Departments.Presenters
{
    class AddEditEmployeePresenter
    {
        AddEditEmployeeIView view;
        Employee model;
        public AddEditEmployeePresenter(AddEditEmployeeIView _view)
        {
            view = _view;
            model = new Employee();
        }

        public ObservableCollection<String> GetDepartments()
        {
            ObservableCollection<String> departments = new ObservableCollection<String>();
            departments.Add("A");
            departments.Add("B");
            departments.Add("C");
            departments.Add("D");
            departments.Add("E");
            departments.Add("F");
            departments.Add("S");
            return departments;
        }

        public void AddEditEmployee()
        {
            try
            {
                if (view.Surname.Trim().Equals("") ||
                    view.FName.Trim().Equals("") ||
                    view.LName.Trim().Equals("") ||
                    view.Department.Equals(""))
                {
                    throw new LackOfInformationException();
                }
                view.Win.DialogResult = true;
                view.Win.Close();
            }
            catch (LackOfInformationException)
            {
                MessageBox.Show("Заполните все поля");
            }
        }
    }
}
