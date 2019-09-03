using System.Windows;
using System.Windows.Controls;

namespace AdiSample.UserControls.UserControl03
{
    /// <summary>
    /// Logika interakcji dla klasy UC03_12_Expander.xaml
    /// </summary>
    public partial class UC03_12_Expander : UserControl
    {
        public UC03_12_Expander()
        {
            InitializeComponent();
        }

        private void CheckBoxChanged(object sender, RoutedEventArgs e)
        {
            CBAllOpcje.IsChecked = null;
            if (CBOpcja1.IsChecked == true && CBOpcja2.IsChecked == true && CBOpcja3.IsChecked == true)
            {
                CBAllOpcje.IsChecked = true;
            }
            if (CBOpcja1.IsChecked == false && CBOpcja2.IsChecked == false && CBOpcja3.IsChecked == false)
            {
                CBAllOpcje.IsChecked = false;
            }
            labelCheckBox.Content = "1 = " + CBOpcja1.IsChecked + ", 2 = " + CBOpcja2.IsChecked + ", 3 = " + CBOpcja3.IsChecked;
        }

        private void CheckBoxChangedAll(object sender, RoutedEventArgs e)
        {
            if (CBAllOpcje.IsChecked == true)
            {
                CBOpcja1.IsChecked = CBOpcja2.IsChecked = CBOpcja3.IsChecked = true;
            }
            if (CBAllOpcje.IsChecked == false)
            {
                CBOpcja1.IsChecked = CBOpcja2.IsChecked = CBOpcja3.IsChecked = false;
            }
        }
    }
}
