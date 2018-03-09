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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Departments
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ObservableCollection<Company> company = new ObservableCollection<Company>();
       
            employeesLV.ItemsSource = company;

            editBTN.Click += delegate
            {
                try
                {
                    int selectedIndex = employeesLV.SelectedIndex;
                    if (selectedIndex == -1)
                    {
                        throw new LackOfInformationException();
                    }
                    EditEmployee editWin = new EditEmployee();
                    editWin.departmentCB.SelectedItem = company[selectedIndex].department;
                    editWin.employeeTB.Text = company[selectedIndex].employee;
                    if (editWin.ShowDialog() == true)
                    {
                        company.RemoveAt(selectedIndex);
                        company.Insert(selectedIndex, new Company { department = editWin.departmentCB.SelectedItem.ToString(), employee = editWin.employeeTB.Text });
                    }
                }
                catch (LackOfInformationException)
                {
                    MessageBox.Show("Выберите сотрудника");
                }
            };

            addBTN.Click += delegate
            {
                AddEmployee addWin = new AddEmployee();
                if (addWin.ShowDialog() == true)
                {
                    company.Add(new Company { department = addWin.departmentCB.SelectedItem.ToString(), employee = addWin.employeeTB.Text });
                }
            };
        }
    }
}
