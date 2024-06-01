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
using System.Windows.Shapes;

namespace GrpProject
{
    /// <summary>
    /// Interaction logic for FirstWindow.xaml
    /// </summary>
    public partial class FirstWindow : Window
    {
        public FirstWindow()
        {
            
            InitializeComponent();
        }

        private void AdminBtn1_Click(object sender, RoutedEventArgs e)
        {
            AdminLoginWindow window = new AdminLoginWindow();
            window.Show();
            this.Close();
        }

        private void StudentBtn1_Click(object sender, RoutedEventArgs e)
        {
            StudentLoginWindow window = new StudentLoginWindow();
            window.Show();
            this.Close();
        }
    }
}
