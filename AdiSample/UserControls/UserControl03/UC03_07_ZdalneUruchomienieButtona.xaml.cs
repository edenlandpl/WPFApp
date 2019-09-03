using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
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
    /// Logika interakcji dla klasy UC03_07_ZdalneUruchomienieButtona.xaml
    /// </summary>
    public partial class UC03_07_ZdalneUruchomienieButtona : UserControl
    {
        int counterClickB01 = 0, counterClickB02 = 0;
        public UC03_07_ZdalneUruchomienieButtona()
        {
            InitializeComponent();
        }

        private void Button071_Click(object sender, RoutedEventArgs e)
        {
            counterClickB01++;
            ButtonAutomationPeer bap = new ButtonAutomationPeer(button072);
            IInvokeProvider iip = bap.GetPattern(PatternInterface.Invoke) as IInvokeProvider;
            iip.Invoke(); // To powoduje kliknięcie przycisku
            label070.Content = "Kliknięcia lewego, a następnie uruchomienie prawego - " + counterClickB01;
        }

        private void Button072_Click(object sender, RoutedEventArgs e)
        {
            counterClickB02++;
            label071.Content = "Prawy Button " + counterClickB02;
        }
    }
}
