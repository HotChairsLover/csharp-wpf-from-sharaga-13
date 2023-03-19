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
    /// Логика взаимодействия для Parents.xaml
    /// </summary>
    public partial class Parents : Page
    {
        public MainWindow mainWindow;
        public Parents(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
        }

        private void NextPage(object sender, EventArgs e)
        {
            bool isError = false;
            bool isMatComplete = false;
            bool isOtecComplete = false;
            bool isOtecIn = false;
            try
            {
                DateTime matdate = Convert.ToDateTime(matRojden.Text);
                if(matDomNumber.Text != "")
                {
                    if (matDomNumber.Text.Length == 8)
                    {
                        int domNumber = Convert.ToInt32(matDomNumber.Text);
                    }
                    else
                    {
                        MessageBox.Show("В домашнем номере должно быть 8 цифр");
                        isError = true;
                    }
                }
                if(matMobNumber.Text != "")
                {
                    if (matMobNumber.Text.Length == 11)
                    {
                        long mobNumber = Convert.ToInt64(matMobNumber.Text);
                    }
                    else
                    {
                        MessageBox.Show("В мобильном номере должно быть 11 цифр");
                        isError = true;
                    }
                }
                for (int i = 0; i < matFio.Text.Length; i++)
                {
                    if (!char.IsLetter(matFio.Text[i]) & matFio.Text[i] != ' ')
                    {
                        isError = true;
                        MessageBox.Show("В ФИО должны быть только буквы");
                        break;
                    }
                }
                for (int i = 0; i < matRabota.Text.Length; i++)
                {
                    if (isError)
                    {                       
                        break;
                    }
                    else if (!char.IsLetter(matRabota.Text[i]))
                    {
                        isError = true;
                        MessageBox.Show("В месте работы должны быть только буквы");
                        break;
                    }
                }
                for (int i = 0; i < matRabotaKem.Text.Length; i++)
                {
                    if (isError)
                    {                        
                        break;
                    }
                    else if (!char.IsLetter(matRabotaKem.Text[i]))
                    {
                        isError = true;
                        MessageBox.Show("В должности должны быть только буквы");
                        break;
                    }
                }
                for (int i = 0; i < matJivetGde.Text.Length; i++)
                {
                    if (isError)
                    {
                        MessageBox.Show("В месте жительства должны быть только буквы и цифры");
                        break;
                    }
                    else if (!char.IsLetter(matJivetGde.Text[i]) & !char.IsDigit(matJivetGde.Text[i]) & matJivetGde.Text[i] != ' ')
                    {
                        isError = true;
                    }
                }
                if(!isError & matdate < DateTime.Today)
                {
                    if(matSoglasen.IsChecked == true)
                    {
                        isMatComplete = true;
                    }
                    else
                    {
                        MessageBox.Show("Необходимо согласие на обработку");
                    }
                }
                if (!isMatComplete || otecDomNumber.Text != "" || otecFio.Text != "" || otecJivetGde.Text != "" || otecMobNumber.Text != "" || otecRabota.Text != ""
                    || otecRabotaKem.Text != "" || otecRojden.Text != "")
                {

                    isOtecIn = true;
                    DateTime otecdate = Convert.ToDateTime(otecRojden.Text);
                    if (otecDomNumber.Text != "")
                    {
                        if (otecDomNumber.Text.Length == 8)
                        {
                            int domNumber = Convert.ToInt32(otecDomNumber.Text);
                        }
                        else
                        {
                            MessageBox.Show("В домашнем номере должно быть 8 цифр");
                            isError = true;
                        }
                    }
                    if (otecMobNumber.Text != "")
                    {
                        if (otecMobNumber.Text.Length == 11)
                        {
                            long mobNumber = Convert.ToInt64(otecMobNumber.Text);
                        }
                        else
                        {
                            MessageBox.Show("В мобильном номере должно быть 11 цифр");
                            isError = true;
                        }
                    }
                    for (int i = 0; i < otecFio.Text.Length; i++)
                    {
                        if (isError)
                        {
                            break;
                        }
                        else if (!char.IsLetter(otecFio.Text[i]) & otecFio.Text[i] != ' ')
                        {
                            isError = true;
                            MessageBox.Show("В ФИО должны быть только буквы");
                            break;
                        }
                    }
                    for (int i = 0; i < otecRabota.Text.Length; i++)
                    {
                        if (isError)
                        {
                            break;
                        }
                        else if (!char.IsLetter(otecRabota.Text[i]))
                        {
                            isError = true;
                            MessageBox.Show("В месте работы должны быть только буквы");
                            break;
                        }
                    }
                    for (int i = 0; i < otecRabotaKem.Text.Length; i++)
                    {
                        if (isError)
                        {
                            break;
                        }
                        else if (!char.IsLetter(otecRabotaKem.Text[i]))
                        {
                            isError = true;
                            MessageBox.Show("В должности должны быть только буквы");
                            break;
                        }
                    }
                    for (int i = 0; i < otecJivetGde.Text.Length; i++)
                    {
                        if (isError)
                        {
                            break;
                        }
                        else if (!char.IsLetter(otecJivetGde.Text[i]) & !char.IsDigit(otecJivetGde.Text[i]) & otecJivetGde.Text[i] != ' ')
                        {
                            isError = true;
                            MessageBox.Show("В месте жительства должны быть только буквы и цифры");
                        }
                    }
                    if (!isError & otecdate < DateTime.Today)
                    {
                        if (otecSoglasen.IsChecked == true)
                        {
                            isOtecComplete = true;
                        }
                        else
                        {
                            MessageBox.Show("Необходимо согласие на обработку");
                        }
                    }
                    if (isOtecComplete)
                    {
                        MessageBox.Show("Заявка отправлена");
                        mainWindow.Close();
                    }
                }
                if (isMatComplete & !isOtecIn)
                {
                    MessageBox.Show("Заявка отправлена");
                    mainWindow.Close();
                }
            }
            catch
            {
                MessageBox.Show("Дата рождения должена быть записана в формате ДД.ММ.ГГГГ. В номерах могут быть только цифры");
            }
        }
    }
}
