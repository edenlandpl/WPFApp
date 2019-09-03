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
using System.Windows.Shapes;

namespace AdiSample
{
    /// <summary>
    /// Logika interakcji dla klasy UC03PopUpWindow.xaml
    /// </summary>
    public partial class UC03PopUpWindow : Window
    {
        public UC03PopUpWindow()
        {
            InitializeComponent();
        }
        void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            if (b != null) b.Foreground = Brushes.GreenYellow;
        }
        void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            if (b != null) b.Foreground = Brushes.Black;
        }
    }
}
