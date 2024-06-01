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
    /// Interaction logic for AddUserWindow2.xaml
    /// </summary>
    public partial class AddUserWindow2 : Window
    {
        public AddUserWindow2(AddUserVM vm)
        {
            InitializeComponent();
            DataContext = vm;
            vm.CloseAction = () => Close();
        }
       

        private void gpatb_Click(object sender, RoutedEventArgs e)
        {
            string a1, a2, a3, a4, a5, a6, a7, a8;
            double gpa, xx, b1, b2, b3, b4, b6, b7, b8;

            a1 = tb1.Text.ToLower();
            a2 = tb2.Text.ToLower();
            a3 = tb3.Text.ToLower();
            a4 = tb4.Text.ToLower();
            a6 = tb6.Text.ToLower();
            a7 = tb7.Text.ToLower();
            a8 = tb8.Text.ToLower();


            if (a1 == "a+" || a1 == "a")
            {
                xx = 4;
                b1 = 3 * xx;
            }
            else if (a1 == "a-")
            {
                xx = 3.7;
                b1 = 3 * xx;
            }
            else if (a1 == "b+")
            {
                xx = 3.3;
                b1 = 3 * xx;
            }
            else if (a1 == "b")
            {
                xx = 3;
                b1 = 3 * xx;
            }
            else if (a1 == "b-")
            {
                xx = 3;
                b1 = 2.7 * xx;
            }
            else if (a1 == "c+")
            {
                xx = 3;
                b1 = 2.3 * xx;
            }
            else if (a1 == "c")
            {
                xx = 2;
                b1 = 3 * xx;
            }
            else if (a1 == "a-")
            {
                xx = 1.7;
                b1 = 3 * xx;
            }
            else
            {
                b1 = 0;
            }




            if (a2 == "a+" || a2 == "a")
            {
                xx = 4;
                b2 = 2 * xx;
            }
            else if (a2 == "a-")
            {
                xx = 3.7;
                b2 = 2 * xx;
            }
            else if (a2 == "b+")
            {
                xx = 3.3;
                b2 = 2 * xx;
            }
            else if (a2 == "b")
            {
                xx = 3;
                b2 = 2 * xx;
            }
            else if (a2 == "b-")
            {
                xx = 2.7;
                b2 = 2 * xx;
            }
            else if (a2 == "c+")
            {
                xx = 2.3;
                b2 = 2 * xx;
            }
            else if (a2 == "c")
            {
                xx = 2;
                b2 = 2 * xx;
            }
            else if (a2 == "a-")
            {
                xx = 1.7;
                b2 = 2 * xx;
            }
            else
            {
                b2 = 0;
            }




            if (a3 == "a+" || a3 == "a")
            {
                xx = 4;
                b3 = 2 * xx;
            }
            else if (a3 == "a-")
            {
                xx = 3.7;
                b3 = 2 * xx;
            }
            else if (a3 == "b+")
            {
                xx = 3.3;
                b3 = 2 * xx;
            }
            else if (a3 == "b")
            {
                xx = 3;
                b3 = 2 * xx;
            }
            else if (a3 == "b-")
            {
                xx = 2.7;
                b3 = 2 * xx;
            }
            else if (a3 == "c+")
            {
                xx = 2.3;
                b3 = 2 * xx;
            }
            else if (a3 == "c")
            {
                xx = 2;
                b3 = 2 * xx;
            }
            else if (a3 == "a-")
            {
                xx = 1.7;
                b3 = 2 * xx;
            }
            else
            {
                b3 = 0;
            }



            if (a4 == "a+" || a4 == "a")
            {
                xx = 4;
                b4 = 3 * xx;
            }
            else if (a4 == "a-")
            {
                xx = 3.7;
                b4 = 3 * xx;
            }
            else if (a4 == "b+")
            {
                xx = 3.3;
                b4 = 3 * xx;
            }
            else if (a4 == "b")
            {
                xx = 3;
                b4 = 3 * xx;
            }
            else if (a4 == "b-")
            {
                xx = 3;
                b4 = 2.7 * xx;
            }
            else if (a4 == "c+")
            {
                xx = 3;
                b4 = 2.3 * xx;
            }
            else if (a4 == "c")
            {
                xx = 2;
                b4 = 3 * xx;
            }
            else if (a4 == "a-")
            {
                xx = 1.7;
                b4 = 3 * xx;
            }
            else
            {
                b4 = 0;
            }



            if (a6 == "a+" || a6 == "a")
            {
                xx = 4;
                b6 = 3 * xx;
            }
            else if (a6 == "a-")
            {
                xx = 3.7;
                b6 = 3 * xx;
            }
            else if (a6 == "b+")
            {
                xx = 3.3;
                b6 = 3 * xx;
            }
            else if (a6 == "b")
            {
                xx = 3;
                b6 = 3 * xx;
            }
            else if (a6 == "b-")
            {
                xx = 3;
                b6 = 2.7 * xx;
            }
            else if (a6 == "c+")
            {
                xx = 3;
                b6 = 2.3 * xx;
            }
            else if (a6 == "c")
            {
                xx = 2;
                b6 = 3 * xx;
            }
            else if (a6 == "a-")
            {
                xx = 1.7;
                b6 = 3 * xx;
            }
            else
            {
                b6 = 0;
            }



            if (a7 == "a+" || a7 == "a")
            {
                xx = 4;
                b7 = 3 * xx;
            }
            else if (a7 == "a-")
            {
                xx = 3.7;
                b7 = 3 * xx;
            }
            else if (a7 == "b+")
            {
                xx = 3.3;
                b7 = 3 * xx;
            }
            else if (a7 == "b")
            {
                xx = 3;
                b7 = 3 * xx;
            }
            else if (a7 == "b-")
            {
                xx = 3;
                b7 = 2.7 * xx;
            }
            else if (a7 == "c+")
            {
                xx = 3;
                b7 = 2.3 * xx;
            }
            else if (a7 == "c")
            {
                xx = 2;
                b7 = 3 * xx;
            }
            else if (a7 == "a-")
            {
                xx = 1.7;
                b7 = 3 * xx;
            }
            else
            {
                b7 = 0;
            }




            if (a8 == "a+" || a8 == "a")
            {
                xx = 4;
                b8 = 2 * xx;
            }
            else if (a8 == "a-")
            {
                xx = 3.7;
                b8 = 2 * xx;
            }
            else if (a8 == "b+")
            {
                xx = 3.3;
                b8 = 2 * xx;
            }
            else if (a8 == "b")
            {
                xx = 3;
                b8 = 2 * xx;
            }
            else if (a8 == "b-")
            {
                xx = 2.7;
                b8 = 2 * xx;
            }
            else if (a8 == "c+")
            {
                xx = 2.3;
                b8 = 2 * xx;
            }
            else if (a8 == "c")
            {
                xx = 2;
                b8 = 2 * xx;
            }
            else if (a8 == "a-")
            {
                xx = 1.7;
                b8 = 2 * xx;
            }
            else
            {
                b8 = 0;
            }







            gpa = (b1 + b2 + b3 + b4 + b6 + b7 + b8) / 18;
            tgpatextbox.Text = Math.Round(gpa, 4, MidpointRounding.ToEven).ToString();


        }

        private void backbutton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

      

        private void exitbutton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    
    }
}
