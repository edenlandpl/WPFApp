using AdiSample.UserControls.UserControl02.DataContext;
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

namespace AdiSample.UserControls.UserControl02
{
    /// <summary>
    /// Logika interakcji dla klasy UC02_02DataContext.xaml
    /// </summary>
    public partial class UC02_02DataContext : UserControl
    {
        public UC02_02DataContext()
        {
            InitializeComponent();
        }

        private void popWindowDataContext(object sender, RoutedEventArgs e)
        {
            DataContextWindow subWindow = new DataContextWindow();
            subWindow.Show();
        }
    }
}
