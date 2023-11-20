using GamesList.Views;
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

        protected void SaveFiles()
        {
            //TODO
        }
    }
}