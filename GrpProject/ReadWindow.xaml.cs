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
    /// Interaction logic for ReadWindow.xaml
    /// </summary>
    public partial class ReadWindow : Window
    {
        public ReadWindow(AddUserVM vm)
        {
            InitializeComponent();
            DataContext = vm;
            vm.CloseAction = () => Close();
        }

        private void backbutton_Click(object sender, RoutedEventArgs e)
        {
            StudentMainWindow window = new StudentMainWindow();
            window.Show();
            this.Close();
        }

        private void exitbutton_Click(object sender, RoutedEventArgs e)
        {
            FirstWindow window = new FirstWindow();
            window.Show();
            this.Close();
        }

       
    }
}
