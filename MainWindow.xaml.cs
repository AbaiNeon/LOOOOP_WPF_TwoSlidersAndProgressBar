using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
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

namespace WpfTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Order> orders;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double num1 = slider1.Value;
            double num2 = slider2.Value;
            double sum = num1 + num2;

            progressBar.Value = sum;

            if (sum > progressBar.Maximum)
            {
                slider1.Value = progressBar.Maximum - slider2.Value;
            }
            
        }

        private void slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double num1 = slider1.Value;
            double num2 = slider2.Value;
            double sum = num1 + num2;

            progressBar.Value = sum;

            if (sum > progressBar.Maximum)
            {
                slider2.Value = progressBar.Maximum - slider1.Value;
            }
        }

        
    }
}
