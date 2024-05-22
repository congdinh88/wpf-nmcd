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
            LoadComboBoxItems();
        }

        private void LoadComboBoxItems()
        {
            _items = new ObservableCollection<string>
            {
                "Apple",
                "Banana",
                "Cherry",
                "Date",
                "Fig",
                "Grape",
                "Honeydew"
            };

            comboBox.ItemsSource = _items;
        }

        private void comboBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            string typedText = comboBox.Text.ToString();

                ObservableCollection<string> filteredItems = new ObservableCollection<string>(_items.Where(i=>i.ToLower().Contains(typedText.ToLower())));
                comboBox.ItemsSource = filteredItems;
                comboBox.IsDropDownOpen = true;

        }
       
    }
}