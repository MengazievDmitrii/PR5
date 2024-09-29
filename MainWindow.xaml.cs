using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace ПР5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
            private ObservableCollection<string> strings = new ObservableCollection<string>();

            public MainWindow()
        {  
            
            InitializeComponent();
            List1.ItemsSource = strings;
        }
            private void b1_Click_1(object sender, RoutedEventArgs e) //добавление
             {
            if (!string.IsNullOrEmpty(tb1.Text))
            {
                strings.Add(tb1.Text);
                tb1.Clear();
            }
            }
        private void b2_click(object sender, RoutedEventArgs e) //изменнеие
        {
            if (List1.SelectedIndex >= 0 && !string.IsNullOrEmpty(tb1.Text))
            {
                strings[List1.SelectedIndex] = tb1.Text;
                tb1.Clear();
            }
        }
        private void b3_click(object sender, RoutedEventArgs e) //удаление
        {
            if (List1.SelectedIndex >= 0)
            {
                strings.RemoveAt(List1.SelectedIndex);
            }
        }

       
        
    }
}
