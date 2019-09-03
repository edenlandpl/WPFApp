using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace AdiSample.UserControls.UserControl03
{
    /// <summary>
    /// Logika interakcji dla klasy UC03_08_RadioButton.xaml
    /// </summary>
    public partial class UC03_08_RadioButton : UserControl
    {
        public UC03_08_RadioButton()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            LabelRadioButton.Content = "Wybrałeś: " + rb.Name + " z grupy:" + rb.GroupName;
        }

        private void ButtonResetRadioButton_Click(object sender, RoutedEventArgs e)
        {
            // To nie działa, nie można ustawić wartości null dla Radio Button
            //RadioButton rb = sender as RadioButton;
            Opcja1.IsChecked = Opcja2.IsChecked = Opcja3.IsChecked = false;
        }

        private void ButtonNullRadioButton_Click(object sender, RoutedEventArgs e)
        {
            Opcja1.IsChecked = Opcja2.IsChecked = Opcja3.IsChecked = null;
        }
    }
}
