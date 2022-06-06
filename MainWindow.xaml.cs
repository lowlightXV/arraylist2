using System;
using System.Collections;
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

namespace arraylist2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayList;
        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();
        }

        

        private void addButton_Click(object sender, RoutedEventArgs e)
        {

            string inputList = textBox.Text;
            arrayList.Add(inputList);
        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            string inputList1 = textBox.Text;
            arrayList.Remove(inputList1);
        }

        private void showButton_Click(object sender, RoutedEventArgs e)
        {
            foreach(string data in arrayList) 
            {
                textBox.AppendText(data);

            }
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
