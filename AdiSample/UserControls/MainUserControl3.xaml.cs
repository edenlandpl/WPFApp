using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for MainUserControl1.xaml
    /// </summary>
    public partial class MainUserControl3 : UserControl
    {
        private object frame;
        public MainUserControl3()
        {
            InitializeComponent();
        }
        string TextToBox01 = "Hello coś";
        
        //public string TextToBox01 { get; set => "Hello start" };
        private void BtnClick_WindowPopUp(object sender, RoutedEventArgs e)
        {
            UC03PopUpWindow windowsPopUp = new UC03PopUpWindow();
            windowsPopUp.Show();
            //windowsPopUp.Close();
        }


        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            TextBoxUC030.Text = textBoxUC303;
        }
        string textBoxUC303 = "Button z kwadracikiem po środku zamiast napisu" + "\r\n" +
            "Uruchamia okno Message. W oknie właściwości przycisków są modulowane na dwa sposoby" +
            "Pierwszy z XAML" +
            "Drugi poprzez kod C#";
    }
}
