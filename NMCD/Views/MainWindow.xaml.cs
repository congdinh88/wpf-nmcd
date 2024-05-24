using NMCD.UserControlApp;
using System.Collections.ObjectModel;
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

namespace NMCD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<string> _items;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_StateChanged(object sender, System.EventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                HeaderBar.Margin = new Thickness(4,4,4,0);
            }
            else
            {
                HeaderBar.Margin = new Thickness(0);
            }
        }

        //private void HeaderBar_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    DragMove();
        //}
    }
}