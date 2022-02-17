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

namespace MySecondWPFProject
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
        private void ButtonAddName_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !lstNames.Items.Contains(txtName.Text))
            {
                if (lstNames.Items.Count >= 6)
                {
                    lstNames.Items.Clear();
                    lstNames.Items.Add(txtName.Text);
                }
                else
                {
                    lstNames.Items.Add(txtName.Text);
                }
                txtName.Clear();
                txtName.Focus();
            }
        }

        private void ButtonDeleteAll_Click(object sender, RoutedEventArgs e)
        {
            lstNames.Items.Clear();
            txtName.Focus();
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                ButtonAddName_Click(sender, e);
            }
        }


        private void ButtonDeleteSpecefic_Click(object sender, RoutedEventArgs e)
        {
            lstNames.Items.Remove(lstNames.SelectedItem);
            if (lstNames.SelectedItem == null)
            {
                btnDelSpecefic.IsEnabled = false;
            }
            txtName.Focus();
        }

        private void lstNames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnDelSpecefic.IsEnabled = true;
        }
    }
}
