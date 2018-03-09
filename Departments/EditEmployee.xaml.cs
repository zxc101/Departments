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

namespace Departments
{
    public partial class EditEmployee : Window
    {
        public EditEmployee()
        {
            InitializeComponent();

            ObservableCollection<String> departments = new ObservableCollection<String>();
            departmentCB.ItemsSource = departments;

            departments.Add("A");
            departments.Add("B");
            departments.Add("C");
            departments.Add("D");
            departments.Add("E");
            departments.Add("F");
            departments.Add("S");

            editBTN.Click += delegate
            {
                try
                {
                    if (employeeTB.Text.Trim().Equals("") || departmentCB.SelectedIndex == -1)
                    {
                        throw new LackOfInformationException();
                    }
                    DialogResult = true;
                    Close();
                }
                catch (LackOfInformationException)
                {
                    MessageBox.Show("Заполните все поля");
                }
            };
        }
    }
}
