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
    /// Логика взаимодействия для Speciality.xaml
    /// </summary>
    public partial class Speciality : Page
    {
        public MainWindow mainWindow;
        public Speciality(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
        }

        private void NextPage(object sender, EventArgs e)
        {
            if(soglasen1.IsChecked == true & soglasen2.IsChecked == true)
            {
                if(perviy.IsChecked == true || nePerviy.IsChecked == true)
                {
                    if(aviaPribodi.IsChecked == true || aditivTextologii.IsChecked == true || isIProgProg.IsChecked == true || isIProgWeb.IsChecked == true
                        || ksIKomp.IsChecked == true || liteynoe.IsChecked == true || mexatronika.IsChecked == true || prikladInform.IsChecked == true
                        || avaDvig.IsChecked == true || radioPribor.IsChecked == true || texMachin.IsChecked == true || texMetall.IsChecked == true
                        || kacvoProd.IsChecked == true)
                    {
                        mainWindow.frame.Navigate(new Pages.Passport(mainWindow));
                    }
                    else
                    {
                        MessageBox.Show("Выбериие хотя бы одну специальность");
                    }
                }
                else
                {
                    MessageBox.Show("Все поля должны быть заполнены");
                }
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены");
            }

        }
    }
}
