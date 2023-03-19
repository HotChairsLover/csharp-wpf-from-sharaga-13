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
    /// Логика взаимодействия для Passport.xaml
    /// </summary>
    public partial class Passport : Page
    {
        public MainWindow mainWindow;
        public Passport(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
        }

        private void NextPage(object sender, EventArgs e)
        {
            bool isError = false;
            try
            {
                if (Convert.ToDateTime(dateOfBirth.Text) < DateTime.Today & Convert.ToDateTime(dateOfVidacha.Text) < DateTime.Today)
                {
                    if (seriaAndNumber.Text.Length != 12 || !seriaAndNumber.Text.Contains(' '))
                    {
                        isError = true;
                        MessageBox.Show("Серия и номер паспорта должны быть записаны в формате СС СС НННННН");
                    }
                    for(int i = 0; i < seriaAndNumber.Text.Length; i++)
                    {
                        if (isError)
                        {
                            break;
                        }
                        else if (!char.IsDigit(seriaAndNumber.Text[i]) & seriaAndNumber.Text[i] != ' ')
                        {
                            isError = true;
                            MessageBox.Show("В серии и номера должны быть только цифры");
                            break;
                        }
                    }
                    if (!isError)
                    {
                        string[] series_and_number_split = seriaAndNumber.Text.Trim().Split(' ');
                        if (series_and_number_split.Length != 3 || series_and_number_split[0].Length != 2 ||
                            series_and_number_split[1].Length != 2 || series_and_number_split[2].Length != 6)
                        {
                            isError = true;
                            MessageBox.Show("Серия и номер паспорта должны быть записаны в формате СС СС НННННН");
                        }
                    }
                    if (!isError)
                    {
                        if(codeProdrazd.Text.Length == 7 & codeProdrazd.Text.Contains('-'))
                        {
                            if (codeProdrazd.Text.Split('-')[0].Length == 3 & codeProdrazd.Text.Split('-')[1].Length == 3)
                            {
                                for (int i = 0; i < name.Text.Length; i++)
                                {
                                    if (isError)
                                    {                                      
                                        break;
                                    }
                                    else if (!char.IsLetter(name.Text[i]))
                                    {
                                        isError = true;
                                        MessageBox.Show("В имени должны быть только буквы");
                                        break;
                                    }
                                }
                                for (int i = 0; i < surname.Text.Length; i++)
                                {
                                    if (isError)
                                    {
                                        break;
                                    }
                                    else if (!char.IsLetter(surname.Text[i]))
                                    {
                                        isError = true;
                                        MessageBox.Show("В фамилии должны быть только буквы");
                                        break;
                                    }
                                }
                                for (int i = 0; i < lastName.Text.Length; i++)
                                {
                                    if (isError)
                                    {
                                        break;
                                    }
                                    else if (!char.IsLetter(lastName.Text[i]))
                                    {
                                        isError = true;
                                        MessageBox.Show("В отчестве должны быть только буквы");
                                        break;
                                    }
                                }
                                for (int i = 0; i < kemVidan.Text.Length; i++)
                                {
                                    if (isError)
                                    {
                                        break;
                                    }
                                    else if (!char.IsLetter(kemVidan.Text[i]) & kemVidan.Text[i] != ' ')
                                    {
                                        isError = true;
                                        MessageBox.Show("В кем выдан должны быть только буквы");
                                        break;
                                    }
                                }
                                for (int i = 0; i < adresProjiv.Text.Length; i++)
                                {
                                    if (isError)
                                    {
                                        break;
                                    }
                                    else if (!char.IsLetter(adresProjiv.Text[i]) && !char.IsDigit(adresProjiv.Text[i]) && adresProjiv.Text[i] != ' ')
                                    {
                                        isError = true;
                                        MessageBox.Show("В адресе проживания должны быть только буквы и цифры");
                                        break;
                                    }
                                }
                                for (int i = 0; i < adresPropiska.Text.Length; i++)
                                {
                                    if (isError)
                                    {
                                        break;
                                    }
                                    else if (!char.IsLetter(adresPropiska.Text[i]) && !char.IsDigit(adresPropiska.Text[i]) && adresPropiska.Text[i] != ' ')
                                    {
                                        isError = true;
                                        MessageBox.Show("В адресе прописки должны быть только буквы и цифры");
                                        break;
                                    }
                                }
                                for (int i = 0; i < raionProjiv.Text.Length; i++)
                                {
                                    if (isError)
                                    {
                                        break;
                                    }
                                    else if (!char.IsLetter(raionProjiv.Text[i]))
                                    {
                                        isError = true;
                                        MessageBox.Show("В районе проживания должны быть только буквы");
                                        break;
                                    }
                                }
                                for (int i = 0; i < raionPropis.Text.Length; i++)
                                {
                                    if (isError)
                                    {
                                        break;
                                    }
                                    else if (!char.IsLetter(raionPropis.Text[i]))
                                    {
                                        isError = true;
                                        MessageBox.Show("В районе прописки должны быть только буквы");
                                        break;
                                    }
                                }
                                for (int i = 0; i < grazdanstvo.Text.Length; i++)
                                {
                                    if (isError)
                                    {
                                        break;
                                    }
                                    else if (!char.IsLetter(grazdanstvo.Text[i]))
                                    {
                                        isError = true;
                                        MessageBox.Show("В гражданстве должны быть только буквы");
                                        break;
                                    }
                                }
                                if (!isError)
                                {
                                    mainWindow.frame.Navigate(new Pages.Contacts(mainWindow));
                                }
                            }
                            else
                            {
                                MessageBox.Show("Код подразделения должен быть записан в формате ХХХ-ХХХ");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Код подразделения должен быть записан в формате ХХХ-ХХХ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Серия и номер должны быть записаны в формате СС СС HHHHHH");
                    }
                  
                }
                else
                {
                    MessageBox.Show("Дата рождения и/или выдачи не может быть больше текущей");
                }
            }
            catch
            {
                MessageBox.Show("Дата рождения и выдачи должна быть записана в формате ДД.ММ.ГГГГ. В серии и номере должны быть только цифры." +
                    "Код подразделения должен быть записан в формате XXX-XXX");
            }           
        }
    }
}
