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

namespace WPF_functionality_3
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

        private void btnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text += txtVoornaam.Text + "\t \t \t" +  txtAchternaam.Text + "\t \t \t" + Convert.ToDouble(txtVerdiensten.Text).ToString("F") + " €" + Environment.NewLine;
            txtAchternaam.Clear();
            txtVoornaam.Clear();
            txtVerdiensten.Clear();



        }
    }
}
