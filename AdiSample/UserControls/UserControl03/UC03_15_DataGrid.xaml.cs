using DotNetOpenAuth.OpenId.Extensions.SimpleRegistration;
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
    /// Logika interakcji dla klasy UC03_15_DataGrid.xaml
    /// </summary>
    public partial class UC03_15_DataGrid : UserControl
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public Uri Website { get; set; }
        public bool IsBillionaire { get; set; }
        public Gender Gender { get; set; } 

        public UC03_15_DataGrid()
        {
            InitializeComponent();
            Loadsample();
        }

        private void Loadsample()
        {
           
        }

        //public enum Gender
        //{
        //    Male,
        //    Female
        //}
    }
}
