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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class PartnerPage : Page
    {
        public PartnerPage()
        {
            InitializeComponent();
            Partner_LW.ItemsSource = YamaletdinovMasterPolEntities.GetContext().Partners.ToList();
            pt_cb.SelectedIndex = 0;
            Update_Agent();
        }
        public void Update_Agent()
        {
            var current_Agent = YamaletdinovMasterPolEntities.GetContext().Partners.ToList();

            if(RadioButton_Up.IsChecked == true)
            {
                current_Agent = current_Agent.OrderBy(p => p.PartnerName).ToList();
            }
            if (RadioButton_Down.IsChecked == true)
            {
                current_Agent = current_Agent.OrderByDescending(p => p.PartnerName).ToList();
            }
            current_Agent = current_Agent.Where(p => p.PartnerName.ToLower().Contains(SerachTB.Text.ToLower()) || p.Email.ToLower().Contains(SerachTB.Text.ToLower()) || p.PhoneFiltr.Contains(SerachTB.Text.Replace("+", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", ""))).ToList();
            if (pt_cb.SelectedIndex == 1)
            {
                current_Agent = current_Agent.Where(p => p.PartnerType == 1).ToList();
            }
            if (pt_cb.SelectedIndex == 2)
            {
                current_Agent = current_Agent.Where(p => p.PartnerType == 2).ToList();
            }
            if (pt_cb.SelectedIndex == 3)
            {
                current_Agent = current_Agent.Where(p => p.PartnerType == 3).ToList();
            }
            if (pt_cb.SelectedIndex == 4)
            {
                current_Agent = current_Agent.Where(p => p.PartnerType == 4).ToList();
            }

            Partner_LW.ItemsSource = current_Agent;
        }
        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage((sender as Button).DataContext as Partners));
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage(null));
        }

        private void SerachTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update_Agent();
        }

        private void RadioButton_Up_Checked(object sender, RoutedEventArgs e)
        {
            Update_Agent();
        }

        private void RadioButton_Down_Checked(object sender, RoutedEventArgs e)
        {
            Update_Agent();
        }

        private void pt_cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update_Agent();
        }
    }
}
