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

namespace Submission_of_Applications.Pages
{
    /// <summary>
    /// Логика взаимодействия для Status.xaml
    /// </summary>
    public partial class Status : Page
    {
        public MainWindow mainWindow;
        public Status(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
        }

        private void NextPage(object sender, EventArgs e)
        {
            if(pripisnoeDa.IsChecked == true || pripisnoeNet.IsChecked == true)
            {
                mainWindow.frame.Navigate(new Pages.Speciality(mainWindow));
            }
            else
            {
                MessageBox.Show("Выберите наличие или отсутствие приписного");
            }
        }
    }
}
