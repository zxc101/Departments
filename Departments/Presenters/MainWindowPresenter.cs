using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Departments.IViews;

namespace Departments.Presenters
{
    class MainWindowPresenter
    {
        ObservableCollection<Employee> company = new ObservableCollection<Employee>();
        MainWindowIView view;
        public MainWindowPresenter(MainWindowIView _view)
        {
            view = _view;
        }
        
        public void EditDepartment()
        {
            try
            {
                int SelectedEmployee = view.SelectedEmployee;
                if (SelectedEmployee == -1)
                {
                    throw new LackOfInformationException();
                }
                AddEditEmployee editWin = new AddEditEmployee();
                editWin.Surname = company[SelectedEmployee].Surname;
                editWin.FName = company[SelectedEmployee].FName;
                editWin.LName = company[SelectedEmployee].LName;
                editWin.Department = company[SelectedEmployee].Department;
                editWin.AddEditBTN.Content = "Редактировать";
                if (editWin.ShowDialog() == true)
                {
                    company.RemoveAt(SelectedEmployee);
                    company.Insert(SelectedEmployee, new Employee { Surname = editWin.Surname,
                                                                 FName = editWin.FName,
                                                                 LName = editWin.LName,
                                                                 Department = editWin.Department });
                }
            }
            catch (LackOfInformationException)
            {
                MessageBox.Show("Выберите сотрудника");
            }
        }

        public void AddDepartment()
        {
            AddEditEmployee addWin = new AddEditEmployee();
            addWin.AddEditBTN.Content = "Добавить";
            if (addWin.ShowDialog() == true)
            {
                company.Add(new Employee
                {
                    Surname = addWin.Surname,
                    FName = addWin.FName,
                    LName = addWin.LName,
                    Department = addWin.Department
                });
            }
        }

        public ObservableCollection<Employee> GetCompany()
        {
            return company;
        }
    }
}
