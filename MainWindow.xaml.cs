using System;
using System.Collections.Generic;
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

namespace WPF_try
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
        public class Data
        {
            public string name { get; set; }
            public string Sname { get; set; }
            public string year { get; set; }
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            
            Data grid = new Data();
            grid.name = Name.Text;
            grid.Sname = SN.Text;
            grid.name = Year.Text;
            DataGridAdd.Items.Add(grid);
        }

        private void Name_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SN_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
