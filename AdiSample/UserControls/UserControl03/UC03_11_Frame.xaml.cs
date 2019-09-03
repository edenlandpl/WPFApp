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
    /// Logika interakcji dla klasy UC03_11_Frame.xaml
    /// </summary>
    public partial class UC03_11_Frame : UserControl
    {
        public UC03_11_Frame()
        {
            InitializeComponent();
        }

        private void Frame_NavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            // Tutaj wstawić obsługę wyjątku Navigation Failed
            frameLabel.Content = "Mamy wyjątek - Navigation Failed";
        }
    }
}
