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
using Departments.Presenters;
using Departments.IViews;

namespace Departments
{
    public partial class MainWindow : Window, MainWindowIView
    {
        public int SelectedEmployee {
            get => employeesLV.SelectedIndex;
        }

        public MainWindow()
        {
            InitializeComponent();

            MainWindowPresenter presenter = new MainWindowPresenter(this);

            editBTN.Click += (s, e) => presenter.EditDepartment();
            addBTN.Click += (s, e) => presenter.AddDepartment();

            employeesLV.ItemsSource = presenter.GetCompany();
        }
    }
}
