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

namespace P2CheckBoxDemo
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
        
        private void cdParent_Changedcheckbox(object sender, RoutedEventArgs e)
        {
            bool newVal = (cbParent.IsChecked == true);
            cbCheese.IsChecked = newVal;
            cbHam.IsChecked = newVal;
            cbTuna.IsChecked = newVal;
            cbPepperoni.IsChecked = newVal;
        }
        private void cdToppings_CheckedChanged(object sender, RoutedEventArgs e)
        {
            cbParent.IsChecked = null;
            if((cbCheese.IsChecked == true) && (cbHam.IsChecked == true) && (cbTuna.IsChecked == true) && (cbPepperoni.IsChecked == true))
            {
                cbParent.IsChecked = true;
                cbSelected.Background = Brushes.LightGray;
            }
            if((cbCheese.IsChecked == false) && (cbHam.IsChecked == false) && (cbTuna.IsChecked == false) && (cbPepperoni.IsChecked == false))
            {
                cbParent.IsChecked = false;
                cbSelected.Background= Brushes.Transparent;
            }
        }
    }
}
