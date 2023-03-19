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
    /// Логика взаимодействия для Contacts.xaml
    /// </summary>
    public partial class Contacts : Page
    {

        public MainWindow mainWindow;
        public Contacts(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
        }

        private void NextPage(object sender, EventArgs e)
        {
            try
            {
                if (mobNumber.Text.Length == 11 & domNumber.Text.Length == 8)
                {
                    long mob = Convert.ToInt64(mobNumber.Text);
                    long dom = Convert.ToInt64(domNumber.Text);
                    if(email.Text != "")
                    {
                        mainWindow.frame.Navigate(new Pages.Parents(mainWindow));
                    }
                    else
                    {
                        MessageBox.Show("Все поля должны быть заполнены");
                    }
                }
                else
                {
                    MessageBox.Show("Мобильный телефон должен быть из 11 цифр, а домашний из 8");
                }
            }
            catch
            {
                MessageBox.Show("В мобильном и домашнем телефонах должны быть только цифры");
            }
        }
    }
}
