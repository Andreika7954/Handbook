using HandBook.Model;
using System;
using System.Collections.Generic;
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

namespace HandBook
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // возможно тут надо подключить БД
            List<Employee> employeesList = new List<Employee>
            {
                new Employee { Surname = "Иванов", Name = "Иван", Patronymic = "Иванович", Telephone = "+7 (499) 564-34-12", Birthday = new DateTime(1985, 4, 13)}
            };

            EmployeeGrid.ItemsSource = employeesList;
        }
    }
}