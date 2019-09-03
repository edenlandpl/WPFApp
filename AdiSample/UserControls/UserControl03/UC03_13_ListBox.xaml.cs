using System.Windows.Controls;

namespace AdiSample.UserControls.UserControl03
{
    /// <summary>
    /// Logika interakcji dla klasy UC03_13_ListBox.xaml
    /// </summary>
    public partial class UC03_13_ListBox : UserControl
    {
        public string DisplayMemberPath { get; set; }

        public UC03_13_ListBox()
        {
            InitializeComponent();
            
        }

        private void ButtonDMP_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            buttonLabel01.Content = "Nazwa Buttona - " + buttonDMP.Content;
            // te dwa poniższe nie działają. Powinny pokazywać długość nazwy i 
            //buttonLabel02.Content = "Długość nazwy Buttona - " + buttonDMP.Content.Lenght;
            //buttonLabel03.Content = "Litera z nazwy o indeksie 2 - " + buttonDMP.Content[2];
        }
    }
}
