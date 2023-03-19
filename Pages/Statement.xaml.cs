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
    /// Логика взаимодействия для Statement.xaml
    /// </summary>
    public partial class Statement : Page
    {
        public MainWindow mainWindow;
        public Statement(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
        }

        private void NextPage(object sender, EventArgs e)
        {
            int todayYear = DateTime.Today.Year;
            if(ochnayaForma.IsChecked == true || zaOchnayaForma.IsChecked == true)
            {
                if(platno.IsChecked == true || besplatno.IsChecked == true)
                {
                    if(okonchil.Text != "")
                    {
                        try
                        {                            
                            if(Convert.ToInt32(godOkonchania.Text) <= todayYear & godOkonchania.Text.Length == 4)
                            {
                                mainWindow.frame.Navigate(new Pages.Education(mainWindow));
                            }
                            else
                            {
                                MessageBox.Show("Год должен состоять из 4 цифр и не быть больше текущего");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("В поле года окончания образовательной организации должен быть только год");
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
            else
            {
                MessageBox.Show("Все поля должны быть заполнены");
            }
        }
    }
}
