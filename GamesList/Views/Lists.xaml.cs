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
using System.Windows.Shapes;

namespace GamesList.Views
{
    /// <summary>
    /// Lógica de interacción para Lists.xaml
    /// </summary>
    public partial class Lists : Window
    {
        public Lists()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            //Owner.IsEnabled = true;
            Owner.Visibility = Visibility.Visible;
            base.OnClosing(e);
        }
    }
}
