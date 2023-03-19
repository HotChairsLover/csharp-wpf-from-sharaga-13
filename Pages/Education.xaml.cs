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
    /// Логика взаимодействия для Education.xaml
    /// </summary>
    public partial class Education : Page
    {
        public MainWindow mainWindow;
        public Education(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
        }

        private void NextPage(object sender, EventArgs e)
        {
            if(klassov9.IsChecked == true || klassov11.IsChecked == true || spo.IsChecked == true || vpo.IsChecked == true)
            {
                if (attestat.IsChecked == true || diplom.IsChecked == true)
                {
                    try
                    {
                        long seria = Convert.ToInt64(seriaAndNomer.Text);
                        if (seriaAndNomer.Text.Length == 10)
                        {
                            if (sredniyBall.Text.Trim().Length == 4 && Convert.ToDouble(sredniyBall.Text) <= 5 && Convert.ToDouble(sredniyBall.Text) >= 2)
                            {
                                mainWindow.frame.Navigate(new Pages.Status(mainWindow));
                            }
                            else
                            {
                                MessageBox.Show("Средний балл не может быть больше 5 и меньше 2 и должнен быть записан до сотых");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Серия и номер должны быть записаны в формате ССССHHHHHH");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("В серии и номере должны содержаться только цифры, в среднем балле тоже");
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
