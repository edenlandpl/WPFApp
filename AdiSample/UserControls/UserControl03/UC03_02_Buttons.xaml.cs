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

namespace AdiSample.UserControls.UserControl03
{
    /// <summary>
    /// Logika interakcji dla klasy UC03_02_Buttons.xaml
    /// </summary>
    public partial class UC03_02_Buttons : UserControl
    {
        public UC03_02_Buttons()
        {
            InitializeComponent();
        }

        void OnClick1(object sender, RoutedEventArgs e)
        {
            button1.Foreground = new SolidColorBrush(Colors.Blue);
            MessageBox.Show("On Hover click event occurs.");
        }
        void OnClick2(object sender, RoutedEventArgs e)
        {
            button2.Foreground = new SolidColorBrush(Colors.Green);
            MessageBox.Show("On Press click event occurs.");
        }
        void OnClick3(object sender, RoutedEventArgs e)
        {
            button1.Foreground = new SolidColorBrush(Colors.Green);
            button2.Foreground = new SolidColorBrush(Colors.Blue);
            MessageBox.Show("On Release click event occurs.");
        }
    }
}
