﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string selectedItems = "";
            foreach (CheckBox item in ListBox.Items)
            {
                if(item.IsChecked == true)
                {
                    selectedItems += item.Content + "\n";
                }
            }
            MessageBox.Show(selectedItems, "Резуьтат");
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}