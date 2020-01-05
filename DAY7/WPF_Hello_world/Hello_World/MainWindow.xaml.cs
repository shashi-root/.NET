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

namespace Hello_World
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
            //bool flag = true;
            //lblOld.Content = "Merry Christmas..";
            //lblHelloHere.Content = "hello";
            //Window1 o = new Window1();
            //o.Show();
            //this.Close();
            if(lblHelloHere.Content.Equals("hello")) {
                lblHelloHere.Content = "Merry Christmas..";
                
            }
            else
            {   
                lblHelloHere.Content = "hello";
            }
             
           
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

       
    }
}
