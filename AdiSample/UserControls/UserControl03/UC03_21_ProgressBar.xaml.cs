using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Logika interakcji dla klasy UC03_21_ProgressBar.xaml
    /// </summary>
    public partial class UC03_21_ProgressBar : UserControl
    {
        public UC03_21_ProgressBar()
        {
            InitializeComponent();
        }
        //private void Window_ContentRendered(object sender, EventArgs e)
        //{
        //    for (int i = 0; i < 100; i++)
        //    {
        //        pbStatus.Value++;
        //        Thread.Sleep(100);
        //    }
        //}

        private void PbButton_Click(object sender, RoutedEventArgs e)
        {
            pbStatus.Value++;
            //for (int i = 0; i < 100; i++)
            //{
            //    pbStatus.Value++;
            //    //Thread.Sleep(100);
            //}
        }
    }
}
