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
    /// Interaction logic for StudentMainWindow.xaml
    /// </summary>
    public partial class StudentMainWindow : Window
    {
        public StudentMainWindow()
        {
            DataContext = new MainWindowVM();
            InitializeComponent();
            
        }

        private void backbtn2_Click(object sender, RoutedEventArgs e)
        {
            StudentLoginWindow window = new StudentLoginWindow();
            window.Show();
            this.Close();
        }

        private void exitbtn2_Click(object sender, RoutedEventArgs e)
        {
            FirstWindow window = new FirstWindow();
            window.Show();
            this.Close();
        }
    }
}
