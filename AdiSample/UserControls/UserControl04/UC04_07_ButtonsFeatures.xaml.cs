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

namespace AdiSample.UserControls.UserControl04
{
    /// <summary>
    /// Logika interakcji dla klasy UC04_07_ButtonsFeatures.xaml
    /// </summary>
    public partial class UC04_07_ButtonsFeatures : UserControl
    {
        int counterRepeatButtonCs = 0;

        public UC04_07_ButtonsFeatures()
        {
            InitializeComponent();
            textBlockTG.Text = "Button - null, niewciśnięty";
        }

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
           counterRepeatButton.Content = counterRepeatButtonCs.ToString();
            counterRepeatButtonCs++;
            Console.Out.WriteLine(counterRepeatButtonCs);
        }
        private void HandleCheck(object sender, RoutedEventArgs e)
        {
            textBlockTG.Text = adiToggleButtonFalse.IsChecked.ToString();
        }

        private void HandleUnchecked(object sender, RoutedEventArgs e)
        {
            textBlockTG.Text = adiToggleButtonFalse.IsChecked.ToString();
        }

        private void HandleNull(object sender, RoutedEventArgs e)
        {
            adiToggleButtonFalse.IsChecked = null;
            textBlockTG.Text = adiToggleButtonFalse.IsChecked.ToString();
            //textBlockTG.Text = "Button is Null";
        }

        private void HandleCheck02(object sender, RoutedEventArgs e)
        {
            textBlockTG02.Text = adiToggleButtonStateTrue.IsChecked.ToString();
        }

        private void HandleUnchecked02(object sender, RoutedEventArgs e)
        {
            textBlockTG02.Text = adiToggleButtonStateTrue.IsChecked.ToString();
        }

        private void HandleNull02(object sender, RoutedEventArgs e)
        {
            textBlockTG02.Text = adiToggleButtonStateTrue.IsChecked.ToString();
        }

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            //adiToggleButton.IsChecked = null;
        }
    }
}
