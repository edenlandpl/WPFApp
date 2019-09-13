using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace AdiSample.UserControls.UserControl04
{
    /// <summary>
    /// Logika interakcji dla klasy UC04_08_DataGrid.xaml
    /// </summary>
    public partial class UC04_08_DataGrid : UserControl
    {
       // List<User> users;

        private List<User> users;

        public List<User> Users
        {
            get { return users; }
            set { users = value; }
        }

        public UC04_08_DataGrid()
        {
            

            InitializeComponent();

            Users = new List<User>();

            Users.Add(new User() { Id = 1, Name = "Wiktor Głąbik" , Birthday = new DateTime(1970, 4, 21) });
            Users.Add(new User() { Id = 2, Name = "Jane Doe", Birthday = new DateTime(1974, 1, 17) });
            Users.Add(new User() { Id = 3, Name = "Sammy Doe", Birthday = new DateTime(1991, 9, 2) });


            dgUsers.ItemsSource = Users;
        }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string ImageUrl { get; set; }
    }

        private void RunDataGrid_Click(object sender, RoutedEventArgs e)
        {

            //List<User> users = new List<User>();
            Users.Add(new User() { Id = 4, Name = "Adi Głąbik", Birthday = new DateTime(1970, 4, 21) });
            Users.Add(new User() { Id = 5, Name = "Jane Doe", Birthday = new DateTime(1974, 1, 17) });
            Users.Add(new User() { Id = 6, Name = "Sammy Doe", Birthday = new DateTime(1991, 9, 2) });

            dgUsers.ItemsSource = Users;
        }
    }

}
