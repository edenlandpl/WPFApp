using System.Windows;
using System.Windows.Controls;

namespace AdiSample
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        TabItem _tabUserPage;
        private void BtnUser1_Click(object sender, RoutedEventArgs e)
        {
            MainTab.Items.Clear(); //Clear previous Items in the user controls which is my tabItems
            var userControls = new MainUserControl1();
            _tabUserPage = new TabItem { Content = userControls };
            MainTab.Items.Add(_tabUserPage); // Add User Controls
            MainTab.Items.Refresh();
        }
        private void BtnUser2_Click(object sender, RoutedEventArgs e)
        {
            MainTab.Items.Clear(); //Clear previous Items in the user controls which is my tabItems
            var userControls = new MainUserControl2();
            _tabUserPage = new TabItem { Content = userControls };
            MainTab.Items.Add(_tabUserPage); // Add User Controls
            MainTab.Items.Refresh();
        }
        private void BtnUser3_Click(object sender, RoutedEventArgs e)
        {
            MainTab.Items.Clear(); //Clear previous Items in the user controls which is my tabItems
            var userControls = new MainUserControl3();
            _tabUserPage = new TabItem { Content = userControls };
            MainTab.Items.Add(_tabUserPage); // Add User Controls
            MainTab.Items.Refresh();
        }
        private void BtnUser4_Click(object sender, RoutedEventArgs e)
        {
            MainTab.Items.Clear(); //Clear previous Items in the user controls which is my tabItems
            var userControls = new MainUserControl4();
            _tabUserPage = new TabItem { Content = userControls };
            MainTab.Items.Add(_tabUserPage); // Add User Controls
            MainTab.Items.Refresh();
        }

        // Standartowe ustawienia wyjścia z programu
        //Odkomentuj to w działąjącym programie
        //////////////////////////////////////////////////////////////////////////////////

        //protected override void OnClosing(CancelEventArgs e)
        //{
        //    base.OnClosing(e);
        //    if (MessageBox.Show("Czy, aby na pewno zamknąć ?",
        //        "Irytujący komunikat", MessageBoxButton.YesNo, MessageBoxImage.Question)
        //    == MessageBoxResult.No)
        //        e.Cancel = true;
        //}

        //protected override void OnClosed(EventArgs e)
        //{
        //    base.OnClosed(e);
        //    //Zapisujemy co trzeba
        //    // Zapisanie kaĪdego elementu ulubionych przy zamykaniu aplikacji
        //    IsolatedStorageFile f = IsolatedStorageFile.GetUserStoreForAssembly();
        //    using (IsolatedStorageFileStream stream =
        //    new IsolatedStorageFileStream("myFile", FileMode.Create, f))
        //    using (StreamWriter writer = new StreamWriter(stream))
        //    {
        //        foreach (TreeViewItem item in favoritesItem.Items)
        //            writer.WriteLine(item.Tag as string);
        //    }
        //}

        //protected override void OnInitialized(EventArgs e)
        //{
        //    base.OnInitialized(e);
        //    // Odczytanie ulubionych przy inicjowaniu aplikacji
        //    IsolatedStorageFile f = IsolatedStorageFile.GetUserStoreForAssembly();
        //    using (IsolatedStorageFileStream stream =
        //    new IsolatedStorageFileStream("myFile", FileMode.OpenOrCreate, f))
        //    using (StreamReader reader = new StreamReader(stream))
        //    {
        //        string line = reader.ReadLine();
        //        while (line != null)
        //        {
        //            AddFavorite(line);
        //            line = reader.ReadLine();
        //        }
        //    }
        //}

        //void exitMenu_Click(object sender, RoutedEventArgs e)
        //{
        //    this.Close();
        //}
        //////////////////////////////////////////////////////////////////////////////////
    }
}
