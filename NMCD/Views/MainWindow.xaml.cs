using NMCD.Pages;
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
        public MainWindow()
        {
            InitializeComponent();
            ListPersonnel.ItemsSource = ShowBtnPer();
        }
        
        private void Window_StateChanged(object sender, System.EventArgs e)
        {
            HeaderBar.Margin= WindowState == WindowState.Maximized? new Thickness(4, 4, 4, 0): new Thickness(0);
        }

        private string[] ShowBtnPer()
        {
            string[] strArray =
            {
                "CBCNV",
                "Nghỉ phép",
                "Lịch trực",
            };
            return strArray;
        }
        private void ListPersonnel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string s = ListPersonnel.SelectedItem.ToString();
            switch (s)
            {
                case "CBCNV":
                    MainContent.Navigate(new Personnel());
                    break;
                case "Nghỉ phép":
                    MainContent.Navigate(new Personnel());
                    break;
                case "Lịch trực":
                    MainContent.Navigate(new Personnel());
                    break;
            }
        }

        private void Expander_Expanded(object sender, RoutedEventArgs e)
        {
            Expander expandedExpander = sender as Expander;

            foreach (Expander expander in LeftMenu.Children)
            {
                if (expander != expandedExpander && expander.IsExpanded)
                {
                    expander.IsExpanded = false;
                }
            }
            LeftMenu.Children.Remove(expandedExpander);
            LeftMenu.Children.Insert(0, expandedExpander);
        }
    }
}