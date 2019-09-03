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

namespace AdiSample
{
    /// <summary>
    /// Logika interakcji dla klasy MainUserControl4.xaml
    /// </summary>
    public partial class MainUserControl4 : UserControl
    {
       
        public MainUserControl4()
        {
            InitializeComponent();
        }

        void AddButtons(object sender, RoutedEventArgs e)
        {
            Button B1 = new Button(), B2 = new Button(), B3 = new Button();
            B1.Content = "Hello";
            B2.Content = "First";
            B3.Content = "Application";
            // Now you can set more properties like height, width, margin etc...
            MyStack.Children.Add(B1);
            MyStack.Children.Add(B2);
            MyStack.Children.Add(B3);
        }

    }
}
