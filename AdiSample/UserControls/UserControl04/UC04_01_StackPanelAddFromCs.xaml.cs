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
    /// Logika interakcji dla klasy UC04_02_StackPanelAddFromCs.xaml
    /// </summary>
    public partial class UC04_02_StackPanelAddFromCs : UserControl
    {
        public UC04_02_StackPanelAddFromCs()
        {
            InitializeComponent();
        }

        void AddButtons(object sender, RoutedEventArgs e)
        {
            Label l01 = new Label();
            Label l02 = new Label();
            l01.Content = "Prawie dobrze, ale za każdym ponownym wgraniem Content, powiela się treść ... lipa ";
            l02.Content = "Kolory Button'ów i Label'ów poprzez Brushes";
            l01.Background = Brushes.Ivory;
            l02.Background = Brushes.Ivory;
            Button B1 = new Button(), B2 = new Button(), B3 = new Button();
            B1.Content = "Hello";
            B2.Content = "First";
            B3.Content = "Application";
            B1.Background = Brushes.DeepSkyBlue;
            B2.Background = Brushes.SeaGreen;
            B3.Background = Brushes.Thistle;
            // Now you can set more properties like height, width, margin etc...
            MyStack.Children.Add(l01);
            MyStack.Children.Add(l02);
            MyStack.Children.Add(B1);
            MyStack.Children.Add(B2);
            MyStack.Children.Add(B3);
        }

    }
}
