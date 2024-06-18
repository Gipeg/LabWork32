using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task3._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<User> users = new List<User>
            {
               new User{Id = 1, Login = "Denis", Password = "123jue"},
               new User{Id = 2, Login = "Denis1", Password = "password1"},
               new User{Id = 3, Login = "Denis2", Password = "password2"},
               new User{Id = 4, Login = "Denis3", Password = "password3"},
               new User{Id = 5, Login = "Denis4", Password = "password5"}
            };

            comboBox.ItemsSource = users;
            listBox.ItemsSource = users;
            listView.ItemsSource = users;
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string users = "";
            foreach (User user in listBox.SelectedItems)
            {
                users += $"{user.Login}\n";
            }
            listBoxLabel.Content = users;
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string users = "";
            foreach (User user in listView.SelectedItems)
            {
                users += $"{user.Login}\n";
            }
            listViewLabel.Content = users;
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            User user = (User)comboBox.SelectedItem;
            comboLabel.Content = $"Id: {user.Id} Login: {user.Login} Password: {user.Password}";
        }
    }
}