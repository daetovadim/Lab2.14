using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab2._14
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProductName = "Телевизор",
                Price = 15000,
                Category = Categories.Electronics
            });
            products.Add(new Product()
            {
                ProductName = "Холодильник",
                Price = 20000,
                Category = Categories.Electronics
            });
            products.Add(new Product()
            {
                ProductName = "Молоко",
                Price = 100,
                Category = Categories.Food
            });
            products.Add(new Product()
            {
                ProductName = "Виски",
                Price = 3000,
                Category = Categories.Food
            });
            lstBox.ItemsSource = products;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            products.Add(new Product()
            {
                ProductName = "Пульт от телевизора",
                Price = 500,
                Category = Categories.Electronics
            });
        }
    }
}
