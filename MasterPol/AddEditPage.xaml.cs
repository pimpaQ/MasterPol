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

namespace MasterPol
{
    /// <summary>
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        int k = 0;
        private Partners _currentAgent = new Partners();
        public AddEditPage(Partners SelectedPartners)
        {
            InitializeComponent();
            if (SelectedPartners != null)
            {
                _currentAgent = SelectedPartners;
                k++;
            }
            DataContext = _currentAgent;
          
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if(string.IsNullOrWhiteSpace(_currentAgent.PartnerName))
            {
                errors.AppendLine("jfdfk");
            }
            if (string.IsNullOrWhiteSpace(_currentAgent.JuridicalIndex))
            {
                errors.AppendLine("Укажите индекс");
            }
            if (!(_currentAgent.JuridicalIndex.Length == 6))
            {
                errors.AppendLine("Укажите правильный индекс");
            }
            if (string.IsNullOrWhiteSpace(_currentAgent.JuridicalState))
            {
                errors.AppendLine("Укажите субъект");
            }
            if (string.IsNullOrWhiteSpace(_currentAgent.JuridicalCity))
            {
                errors.AppendLine("Укажите город");
            }
            if (string.IsNullOrWhiteSpace(_currentAgent.JuridicalStreet))
            {
                errors.AppendLine("Укажите улицу");
            }
            if (string.IsNullOrWhiteSpace(_currentAgent.JuridicalHome.ToString()))
            {
                errors.AppendLine("Укажите номер дома");
            }
            if (_currentAgent.JuridicalHome <= 0)
            {
                errors.AppendLine("Укажите положительный номер дома");
            }
            if (string.IsNullOrWhiteSpace(_currentAgent.DirectorName))
            {
                errors.AppendLine("Укажите директора");
            }
            if (string.IsNullOrWhiteSpace(_currentAgent.INN))
            {
                errors.AppendLine("Укажите ИНН");
            }
            if (string.IsNullOrWhiteSpace(_currentAgent.Rate.ToString()))
            {
                errors.AppendLine("Укажите приоритет");
            }
            if (CB_Sel.SelectedItem == null)
            {
                errors.AppendLine("Укажите тип агента");
            }
            if (_currentAgent.Rate <= 0)
                errors.AppendLine("Укажите положительный приоритет");
            if (string.IsNullOrWhiteSpace(_currentAgent.Email))
            {
                errors.AppendLine("Укажите Email");
            }
            else if (!_currentAgent.Email.Contains('@') && !_currentAgent.Email.Contains('.'))
            {
                errors.AppendLine("Укажите почту правильно");
            }
            if (string.IsNullOrWhiteSpace(_currentAgent.Phone))
            {
                errors.AppendLine("Укажите телефон");
            }
            else
            {
                string ph = _currentAgent.Phone;
                if (((ph[1] == '9' || ph[1] == '4' || ph[1] == '8') && ph.Length != 11) || ph[1] == '3' && ph.Length != 12)
                    errors.AppendLine("Введите телефон правильно");
            }
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            _currentAgent.PartnerType = CB_Sel.SelectedIndex + 1;
            if(_currentAgent.ID == 0)
            {
                YamaletdinovMasterPolEntities.GetContext().Partners.Add(_currentAgent);
            }
            try
            {
                YamaletdinovMasterPolEntities.GetContext().SaveChanges();
                MessageBox.Show("Saves success");
                Manager.MainFrame.GoBack();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
