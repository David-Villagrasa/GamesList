using GamesList.Views;
using System.ComponentModel;
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

namespace GamesList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        protected void OpenLists(object sender, RoutedEventArgs e)
        {
            Lists lists = new Lists();
            lists.Owner = this;
            //this.IsEnabled = false;
            this.Visibility = Visibility.Hidden;
            lists.Show();
        }
        protected void OpenConfiguration(object sender, RoutedEventArgs e)
        {
            Configuration configuration = new Configuration();
            configuration.Owner = this;
            //this.IsEnabled = false;
            this.Visibility = Visibility.Hidden;
            configuration.Show();
        } 

        protected void OpenAbout(object sender, RoutedEventArgs e)
        {
            About about = new About();
            about.Owner = this;
            //this.IsEnabled = false;
            this.Visibility = Visibility.Hidden;
            about.Show();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            //TODO Ask about if the user want to exit saving or not saving the changes
            SaveFiles();
        }

        protected void SaveFiles()
        {
            //TODO
        }

        protected void Exit()
        {
            this.Close();
        }
    }
}